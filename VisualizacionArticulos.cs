using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventario
{
    internal class VisualizacionArticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            Data accesoDatos = new Data();

            try
            {
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre,  A.Descripcion, M.Descripcion Nombre_Marca, A.IdCategoria, A.Precio FROM ARTICULOS A, MARCAS M  WHERE A.IdMarca = M.Id");
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
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
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
    }
}
