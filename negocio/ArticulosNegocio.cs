using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using dominio;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            Data accesoDatos = new Data();

            try
            {

                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Nombre_Marca, "
                    + "C.Descripcion Nombre_Categoria, M.Id Id_Marca, C.Id Id_Categoria, A.Precio, I.ImagenUrl UrlImagen FROM ARTICULOS A JOIN CATEGORIAS C " +
                    "ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id ORDER BY A.Id ASC");



                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo artCargado = lista.Find(a => a.Id == (int)accesoDatos.Lector["Id"]);
                    if (artCargado != null)
                    {
                        // le agrego la imagen nueva y avanzo al siguiente registro.
                        Imagen imagen = new Imagen();
                        imagen.Url = (string)accesoDatos.Lector["UrlImagen"];
                        lista[lista.Count - 1].Imagenes.Add(imagen);
                        continue;

                    }
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    //Creacion de Marca y relacion en datagrip
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatos.Lector["Id_Marca"];
                    articulo.Marca.Nombre = (string)accesoDatos.Lector["Nombre_Marca"];
                    //Creacion de Categoria y relacion en datagrip
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatos.Lector["Id_Categoria"];
                    articulo.Categoria.Nombre = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];
                    articulo.Imagenes = new List<Imagen>();

                    // si no tiene imagenes, no se cargan en el objeto
                    if (!(accesoDatos.Lector["UrlImagen"] is DBNull))
                    {
                        Imagen auxImagen = new Imagen();
                        auxImagen.Url = (string)accesoDatos.Lector["UrlImagen"];
                        articulo.Imagenes.Add(auxImagen);
                    }


                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void agregar(Articulo articuloNuevo)
        {
            Data datos = new Data();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES('" + articuloNuevo.CodigoArticulo + "', '" + articuloNuevo.Nombre + "', '" + articuloNuevo.Descripcion + "', @IdMarca, @IdCategoria, " + articuloNuevo.Precio + ")");
                datos.setearParametro("@IdMarca", articuloNuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", articuloNuevo.Categoria.Id);
                datos.ejecutarAccion(); // cambio de ejecutarLectura a Accion porque es INSERT


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                if (articuloNuevo.Imagenes != null)
                    this.agregarImagenes(articuloNuevo);
            }
        }

        private void agregarImagenes(Articulo articulo)
        {
            int idArticulo;
            if (articulo.Id != 0)
            {
                // artículo en modificación. quitamos imagenes previas y cargamos nuevas
                idArticulo = articulo.Id;
                this.quitarImagenes(idArticulo);
            }
            else
            {
                // artículo nuevo. buscamos el último artículo agregado, para vincular imagenes a su Id
                Articulo ultimoArticulo = this.listar().OrderBy(art => art.Id).Last();
                idArticulo = ultimoArticulo.Id;

            }

            try
            {
                // Agregar imagenes relacionadas

                foreach (Imagen imagen in articulo.Imagenes)
                {
                    this.agregarImagen(imagen, idArticulo);
                }

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void quitarImagenes(int idArticulo)
        {
                Data datos = new Data();
            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @Id");
                datos.setearParametro("@Id", idArticulo);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void agregarImagen(Imagen imagen, int idArticulo)
        {
            Data datos = new Data();
            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @Url)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@Url", imagen.Url);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void modificar(Articulo articuloModificado)
        {
            Data datos = new Data();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@codigo", articuloModificado.CodigoArticulo);
                datos.setearParametro("@nombre", articuloModificado.Nombre);
                datos.setearParametro("@descripcion", articuloModificado.Descripcion);
                datos.setearParametro("@idmarca", articuloModificado.Marca.Id);
                datos.setearParametro("@idcategoria", articuloModificado.Categoria.Id);
                datos.setearParametro("@precio", articuloModificado.Precio);
                datos.setearParametro("@id", articuloModificado.Id);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();

                this.agregarImagenes(articuloModificado);

            }
        }

        public static List<Articulo> buscarArticulos(ParametrosBusqueda busqueda)
        {
            List<Articulo> lista = new List<Articulo>();

            Data accesoDatos = new Data();

            try
            {
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Nombre_Marca, C.Descripcion Nombre_Categoria, " +
                    "A.Precio FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id " +
                    "WHERE Codigo LIKE '%" + busqueda.CodArticulo + "%'");



                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    //Creacion de Marca y relacion en datagrip
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Marca.Nombre = (string)accesoDatos.Lector["Nombre_Marca"];
                    //Creacion de Categoria y relacion en datagrip
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Categoria.Nombre = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];


                    lista.Add(articulo);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }


        }

        public void eliminar(int id)
        {
            try
            {
                Data datos = new Data();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
