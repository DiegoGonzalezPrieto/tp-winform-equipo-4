using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    internal class Articulo
    {
        public int Id { get; set; }
        public  string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public Marca Marca { get; set; }
        
        // A futuro Marca sera de tipo Marca
        //public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        // A futuro Categoria sera de tipo Marca
        //public Categoria Categoria { get; set; }

        public List<Imagen> Imagen { get; set; }

        // A futuro reemplazamos Imagen por lista de imagenes
        //public List<Imagen> Imagenes { get; set; }
        
        public decimal Precio { get; set; }
    }
}
