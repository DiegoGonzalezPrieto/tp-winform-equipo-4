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
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            FrmAgregarMarca modificarMarca = new FrmAgregarMarca(seleccionado);
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
            cargarMarca();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Marca selecionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            MarcasNegocio negocio = new MarcasNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar la marca: " + selecionado.Nombre, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(selecionado.Id);
                    cargarMarca();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
