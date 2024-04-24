using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FrmVentanaImagenes : Form
    {
        public List<Imagen> ListaLinkImagenes { get; } = new List<Imagen>();

        public bool Resultado { get; set; } = false;
        public FrmVentanaImagenes()
        {
            InitializeComponent();
        }
        public FrmVentanaImagenes(List<Imagen> imagenes)
        {
            if (imagenes.Count == 0)
            {
                InitializeComponent();
                return;
            }

            ListaLinkImagenes = imagenes;
            InitializeComponent();
            dgvImagenes.DataSource = ListaLinkImagenes;

            //Oculta las colmnas Id y IdArticulo
            dgvImagenes.Columns["Id"].Visible = false;
            dgvImagenes.Columns["IdArticulo"].Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Resultado = false;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Resultado = true;
            Close();
        }

        private void FrmVentanaImagenes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarLink_Click(object sender, EventArgs e)
        {

            try
            {

                Imagen linkImagen = new Imagen();
                linkImagen.Url = txtLink.Text;

                if (linkImagen.Url.Trim() == "")
                {
                    txtLink.Clear();
                    return;
                }

                ListaLinkImagenes.Add(linkImagen);
                txtLink.Clear();

                if (dgvImagenes.DataSource != null)
                    dgvImagenes.DataSource = null;

                dgvImagenes.DataSource = ListaLinkImagenes;
                //Oculta las colmnas Id y IdArticulo
                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["IdArticulo"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pxbImagenes.Load(imagen);

            }
            catch (Exception ex)
            {
                pxbImagenes.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }

        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.SelectedRows.Count == 0)
            {
                return;
            }
            //if (dgvImagenes.CurrentRow.DataBoundItem != null)
            //{
            try
            {
                Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Url);
            }
            catch (Exception)
            {
                cargarImagen("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
            //}
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null)
                return;

            try
            {
                Imagen imagen = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                ListaLinkImagenes.Remove(imagen);
                dgvImagenes.DataSource = null;
                dgvImagenes.DataSource = ListaLinkImagenes;
                //Oculta las colmnas Id y IdArticulo
                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["IdArticulo"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
