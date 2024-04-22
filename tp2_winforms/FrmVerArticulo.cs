using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace Inventario
{
    public partial class FrmVerArticulo : Form
    {
        private Articulo articulo = null;
        public FrmVerArticulo()
        {
            InitializeComponent();
        }

        public FrmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void FrmVerArticulo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("F2");
            lblMarca.Text = articulo.Marca.Nombre;
            lblCategoria.Text = articulo.Categoria.Nombre;

        }
    }
}
