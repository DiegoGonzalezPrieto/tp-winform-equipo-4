using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class LeerCategorias
    {
        /// <summary>
        ///  Obtiene lista de Categorías de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Categoria> ListaCategorias()
        {
            {
                List<Categoria> ListaDeCategorias = new List<Categoria>();
                Data datosDeCategorias = new Data();

                try
                {
                    datosDeCategorias.setearConsulta("SELECT id, descripcion FROM CATEGORIAS");
                    datosDeCategorias.ejecutarLectura();


                    while(datosDeCategorias.Lector.Read())
                    {

                        Categoria categoria = new Categoria();
                        categoria.Id = (int)datosDeCategorias.Lector["id"];
                        categoria.Nombre = (string)datosDeCategorias.Lector["Descripcion"];

                        ListaDeCategorias.Add(categoria);
                    }
                    return ListaDeCategorias;
                }

                catch (Exception ex)
                {

                    throw ex;

                } finally { datosDeCategorias.cerrarConexion(); }


            }
        }
    }
}
