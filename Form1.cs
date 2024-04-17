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
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tlsNuevoArticulo_Click(object sender, EventArgs e)
        {
            AgregarArticulo ventanaAgregar = new AgregarArticulo();
            ventanaAgregar.ShowDialog();
        }

        private void pRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarArticulo ventanaModificar = new ModificarArticulo();
            ventanaModificar.ShowDialog();
        }
    }
}
