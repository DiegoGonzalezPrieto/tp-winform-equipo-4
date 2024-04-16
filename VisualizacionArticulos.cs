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
                accesoDatos.setearConsulta("SELECT Id, Codigo, Nombre,  Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Marca = (int)accesoDatos.Lector["IdMarca"];
                    articulo.Categoria = (int)accesoDatos.Lector["IdCategoria"];
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
