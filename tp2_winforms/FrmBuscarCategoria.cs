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
        private List<Categoria> categoriasListada;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro != "")
            {
                listaFiltrada = categoriasListada.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = categoriasListada;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvCategorias.CurrentRow != null)
            {
                Categoria seleccionado;
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                FrmAgregarCategoria modificarCategoria = new FrmAgregarCategoria(seleccionado);
                modificarCategoria.Text = "Modificar Categoria";
                modificarCategoria.ShowDialog();
                cargarCategoria();
            }
            else
            {
                MessageBox.Show("No a seleccionado ningun elemento para editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvCategorias.CurrentRow != null)
                {
                    Categoria selecionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    CategoriasNegocio negocio = new CategoriasNegocio();

                    DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar la categoría?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (negocio.eliminar(selecionado.Id))
                        {
                            MessageBox.Show("Categoría eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar la categoría porque está asociada a artículos existentes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        cargarCategoria();
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningún elemento para eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

}
