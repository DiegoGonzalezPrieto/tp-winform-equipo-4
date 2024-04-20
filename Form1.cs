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

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FrmBuscar frmBuscar = new FrmBuscar();
            frmBuscar.ShowDialog();
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
            NuevoDato nuevaMarca = new NuevoDato();
            nuevaMarca.Text = "Nueva Marca";
            nuevaMarca.ShowDialog();
        }

        private void modificarMarca_Click(object sender, EventArgs e)
        {
            NuevoDato modificarMarca = new NuevoDato();
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
        }
    }
}
