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
            ArticulosNegocio articulos = new ArticulosNegocio();
            try
            {
                articuloListados = articulos.listar();

                dgvArticulos.DataSource = articuloListados;
                ocultarColumna();
               
                obtenerImagenPbxArticulo(articuloListados[0].Imagenes[0].Url);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumna()
        {
            dgvArticulos.Columns["Id"].Visible = false;
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
           
            Articulo articuloSeleccionado;
            articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            FrmVerArticulo verArticulo = new FrmVerArticulo(articuloSeleccionado);
            verArticulo.ShowDialog();

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


        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarArticulo frmBuscar = new FrmBuscarArticulo();
            frmBuscar.ShowDialog();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ModificarArticulo ventanaModificar = new ModificarArticulo(seleccionado);
            ventanaModificar.ShowDialog();
            cargarListadoArticulos();

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

        private void dataArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                obtenerImagenPbxArticulo(art.Imagenes[0].Url);
            }
           
        }

        private void obtenerImagenPbxArticulo(string url)
        {
            try
            {
                pbxImagenArticulo.Load(url);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://placehold.co/600x400@2x.png?text=%F0%9F%98%85");
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            decimal filtroNumerico;
            bool precio = Decimal.TryParse(filtro, out filtroNumerico);

            if (filtro != "")
            {
                listaFiltrada = articuloListados.FindAll(x => x.CodigoArticulo.ToUpper().Contains(filtro.ToUpper())
                || x.Nombre.ToUpper().Contains(filtro.ToUpper())
                || x.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || x.Marca.Nombre.ToUpper().Contains(filtro.ToUpper())
                || x.Categoria.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = articuloListados;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumna();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo selecionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar\n "+ selecionado.Marca+ " " + selecionado.Nombre, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.eliminar(selecionado.Id);
                    cargarListadoArticulos();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buscarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarArticulo frmBuscarArticulo = new FrmBuscarArticulo();
            frmBuscarArticulo.ShowDialog();
        }
    }
}
