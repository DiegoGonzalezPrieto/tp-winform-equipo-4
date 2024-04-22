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
using negocio;

namespace Inventario
{
    public partial class FrmBuscarArticulo : Form
    {
        private List<Marca> listaMarca;
        public FrmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca modificarMarca = new FrmAgregarMarca();
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
        }

        private void cargarMarca()
        {
            List<Marca> marcasNegocio = MarcasNegocio.ListaMarcas();
            try
            {
                listaMarca = marcasNegocio;
                dgvMarcas.DataSource = listaMarca;
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txbCodigoArticulo_TextChanged(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada;
            string filtro = txbBuscar.Text;

            if (filtro != "")
            {
                listaFiltrada = listaMarca.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                
            }
            else
            {
                listaFiltrada = listaMarca;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltrada;
            dgvMarcas.Columns["Id"].Visible = false;

        }
    }
}
