using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FrmBuscarCategoria : Form
    {
        List<Categoria> categoriasListada;
        public FrmBuscarCategoria()
        {
            InitializeComponent();
        }

        private void FrmBuscarCategoria_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

        private void cargarCategoria()
        {
            List<Categoria> categoriasNegocio = CategoriasNegocio.ListaCategorias();
            try
            {
                categoriasListada = categoriasNegocio;
                dgvCategorias.DataSource = categoriasListada;
                dgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
