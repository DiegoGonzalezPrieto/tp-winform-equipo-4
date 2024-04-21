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
    public partial class VentanaPrincipal : Form
    {
        private List<Articulo> articuloListados;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargarListadoArticulos();
        }

        private void cargarListadoArticulos()
        {
            VisualizacionArticulos articulos = new VisualizacionArticulos();
            try
            {
                articuloListados = articulos.listar();

                dataArticulos.DataSource = articuloListados;
                dataArticulos.Columns["Id"].Visible = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void nuevoArticulo_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventanaAgregar = new AgregarArticulo();
            ventanaAgregar.ShowDialog();
            cargarListadoArticulos();
        }

        private void nuevaMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca nuevaMarca = new FrmAgregarMarca();
            nuevaMarca.Text = "Nueva Marca";
            nuevaMarca.ShowDialog();
        }

        private void modificarMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca modificarMarca = new FrmAgregarMarca();
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerArticulo frm = new FrmVerArticulo();

            frm.ShowDialog();
        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventanaAgregar = new AgregarArticulo();
            ventanaAgregar.ShowDialog();
            cargarListadoArticulos();
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca nuevaMarca = new FrmAgregarMarca();
            nuevaMarca.Text = "Nueva Marca";
            nuevaMarca.ShowDialog();
        }

        private void modificarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca modificarMarca = new FrmAgregarMarca();
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarArticulo frmBuscar = new FrmBuscarArticulo();
            frmBuscar.ShowDialog();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarArticulo ventanaModificar = new ModificarArticulo();
            ventanaModificar.ShowDialog();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria nuevaCategoria = new FrmAgregarCategoria();
            nuevaCategoria.Text = "Nueva Categoria";
            nuevaCategoria.ShowDialog();
        }

        private void modificarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria ModificarCategoria = new FrmAgregarCategoria();
            ModificarCategoria.Text = "Modificar Categoria";
            ModificarCategoria.ShowDialog();
        }
    }
}
