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
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";
                ocultarColumna();
               
                obtenerImagenPbxArticulo(articuloListados[0].Imagenes);
                
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
           if(dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado;
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmVerArticulo verArticulo = new FrmVerArticulo(articuloSeleccionado);
                verArticulo.ShowDialog();
            }
            

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
            FrmBuscarMarca frmBuscar = new FrmBuscarMarca();
            frmBuscar.ShowDialog();
        }

        private void modificarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ModificarArticulo ventanaModificar = new ModificarArticulo(seleccionado);
                ventanaModificar.ShowDialog();
                cargarListadoArticulos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el articulo a modificar");
            }
           

        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCategoria nuevaCategoria = new FrmAgregarCategoria();
            nuevaCategoria.Text = "Nueva Categoria";
            nuevaCategoria.ShowDialog();
        }

        private void dataArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                obtenerImagenPbxArticulo(art.Imagenes);
            }
           
        }

        private void obtenerImagenPbxArticulo(List<Imagen> imagenes)
        {
            // si no tiene imagenes, cargar placeholder y volver
            if (imagenes.Count == 0)
            {
                pbxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
                return;
            }

            try
            {
                pbxImagenArticulo.Load(imagenes[0].Url);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
                //pbxImagenArticulo.Load("https://bcs-management.com/wp-content/uploads/2017/02/2000px-No_image_available.svg_-1024x1024.png");
                //pbxImagenArticulo.Load("https://placehold.co/600x400@2x.png?text=%F0%9F%98%85");
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo selecionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticulosNegocio negocio = new ArticulosNegocio();

                try
                {
                    DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar\n " + selecionado.Marca + " " + selecionado.Nombre, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Debe seleccionar primero el articulo a eliminar");
            }
            
        }

        private void buscarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarMarca frmBuscarMarca = new FrmBuscarMarca();
            frmBuscarMarca.ShowDialog();
        }

        private void buscarCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarCategoria frmBuscarCategoria = new FrmBuscarCategoria();
            frmBuscarCategoria.ShowDialog();
        }
    }
}
