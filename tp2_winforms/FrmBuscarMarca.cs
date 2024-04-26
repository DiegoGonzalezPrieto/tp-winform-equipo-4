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
    public partial class FrmBuscarMarca : Form
    {
        private List<Marca> listaMarca;
        public FrmBuscarMarca()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca seleccionado;
                seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                FrmAgregarMarca modificarMarca = new FrmAgregarMarca(seleccionado);
                modificarMarca.Text = "Modificar Marca";
                modificarMarca.ShowDialog();
                cargarMarca();
            }
            else
            {
                MessageBox.Show("No a seleccionado ningun elemento para editar");
            }

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

            try
            {
                if (dgvMarcas.CurrentRow != null)
                {
                    Marca selecionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    MarcasNegocio negocio = new MarcasNegocio();

                    DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar\n la marca: " + selecionado.Nombre, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (negocio.eliminar(selecionado.Id))
                        {
                            MessageBox.Show("Marca eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar la marca porque está asociada a artículos existentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        cargarMarca();
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun elemento para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
