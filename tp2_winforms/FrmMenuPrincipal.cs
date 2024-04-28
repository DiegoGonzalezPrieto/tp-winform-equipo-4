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
using static System.Net.Mime.MediaTypeNames;

namespace Inventario
{
    public partial class VentanaPrincipal : Form
    {
        private List<Articulo> articuloListados;
        public VentanaPrincipal()
        {
            InitializeComponent();
            dgvArticulos.CellMouseDown += dgvArticulos_CellMouseDown;

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            cargarListadoArticulos();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Nombre");
        }

        private void cargarListadoArticulos()
        {
            ArticulosNegocio articulos = new ArticulosNegocio();
            try
            {
                articuloListados = articulos.listar();

                dgvArticulos.DataSource = articuloListados;
                //dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";
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
            dgvArticulos.Columns["Precio"].Visible = false;
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
            verDetalleArticulo();

        }

        private void verDetalleArticulo()
        {
            if (dgvArticulos.CurrentRow != null)
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
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ModificarArticulo ventanaModificar = new ModificarArticulo(seleccionado);
                ventanaModificar.ShowDialog();
                cargarListadoArticulos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el articulo a modificar", "No se seleccion ningun articulo");
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
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                obtenerImagenPbxArticulo(art.Imagenes);
            }

        }

        private void obtenerImagenPbxArticulo(List<Imagen> imagenes, int indice = 0, bool siguienteImagen = true)
        {
            // si no tiene imagenes, cargar placeholder y volver
            if (imagenes.Count == 0)
            {
                pbxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
                return;
            }

            // intenta hasta encontrar una imagen que funcione.
            // si vuelve al inicio, deja imagen por defecto
            int i = indice;
            do
            {
                try
                {
                    pbxImagenArticulo.Load(imagenes[i].Url);
                    return;

                }
                catch (Exception)
                {
                    if (siguienteImagen)
                    {
                        if (i < imagenes.Count - 1)
                            i++;
                        else
                            i = 0;

                    }
                    else
                    {
                        if (i != 0)
                            i--;
                        else
                            i = imagenes.Count - 1;
                    }
                }
            } while (i != indice);

            pbxImagenArticulo.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            return;
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
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo selecionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                ArticulosNegocio negocio = new ArticulosNegocio();

                try
                {
                    DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar\n " + selecionado.Marca + " " + selecionado.Nombre + " ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                MessageBox.Show("Debe seleccionar primero el articulo a eliminar", "No se seleccion ningun articulo");
            }

        }

        private void buscarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarMarca frmBuscarMarca = new FrmBuscarMarca();
            frmBuscarMarca.ShowDialog();
            cargarListadoArticulos();
        }

        private void buscarCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBuscarCategoria frmBuscarCategoria = new FrmBuscarCategoria();
            frmBuscarCategoria.ShowDialog();
            cargarListadoArticulos();
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            verDetalleArticulo();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");

            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");

            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articulosFiltrados = new ArticulosNegocio();

            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                dgvArticulos.DataSource = articulosFiltrados.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnBorrarFiltro_Click(object sender, EventArgs e)
        {

            cargarListadoArticulos();
            cboCriterio.Text = "";
            cboCampo.Text = "";
            txtFiltroAvanzado.Text = "";
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.", "Accion No Permitida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Ingrese un número para completar el filtro");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Para filtrar por precio solo puede ingresar números");
                    return true;
                }

            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void ayudaSobreLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/scl/fi/jcrcngytibq5qw5ay1sqg/Ayuda-de-Gestion-de-Articulos.pdf?rlkey=1zgcc5j5wu7krgvmcog03xqjf&st=nkw6lb03&dl=0");
        }

        private void acercaDeLaAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                return;

            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (articuloSeleccionado.Imagenes.Count == 0)
                return;

            try
            {
                string urlImagen = pbxImagenArticulo.ImageLocation;
                int indiceActual = articuloSeleccionado.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual < articuloSeleccionado.Imagenes.Count - 1)
                {
                    obtenerImagenPbxArticulo(articuloSeleccionado.Imagenes, indiceActual + 1);
                }
                else
                {
                    // ir a imagen inicial
                    obtenerImagenPbxArticulo(articuloSeleccionado.Imagenes, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void lblAnterior_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                return;

            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            if (articuloSeleccionado.Imagenes.Count == 0)
                return;

            try
            {
                string urlImagen = pbxImagenArticulo.ImageLocation;
                int indiceActual = articuloSeleccionado.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual > 0)
                {
                    obtenerImagenPbxArticulo(articuloSeleccionado.Imagenes, indiceActual - 1, false);
                }
                else
                {
                    // ir a imagen final
                    obtenerImagenPbxArticulo(articuloSeleccionado.Imagenes, articuloSeleccionado.Imagenes.Count - 1, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void dgvArticulos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ContextMenuStrip menuCD = new ContextMenuStrip();
            ToolStripMenuItem atajoModificar = new ToolStripMenuItem("Modificar");
            ToolStripMenuItem atajoEliminar = new ToolStripMenuItem("Eliminar");

            atajoModificar.Click += atajoModificar_Click;
            atajoEliminar.Click += atajoEliminar_Click;


            menuCD.Items.Add(atajoModificar);
            menuCD.Items.Add(atajoEliminar);

            if (e.Button == MouseButtons.Right)
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dgvArticulos.CurrentCell = dgvArticulos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    menuCD.Show(Cursor.Position);
                }
            }
        }
        private void atajoModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ModificarArticulo ventanaModificar = new ModificarArticulo(seleccionado);
            ventanaModificar.ShowDialog();
            cargarListadoArticulos();
        }

        private void atajoEliminar_Click(object sender, EventArgs e)
        {
            Articulo selecionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ArticulosNegocio negocio = new ArticulosNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de querer eliminar\n " + selecionado.Marca + " " + selecionado.Nombre + " ", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
