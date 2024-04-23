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
        private List<Imagen> listaLinkImagenes = new List<Imagen>();
        public FrmVentanaImagenes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmVentanaImagenes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarLink_Click(object sender, EventArgs e)
        {
            Imagen linkImagen = new Imagen {Url = txtLink.Text};

            listaLinkImagenes.Add(linkImagen);
            txtLink.Clear();

            
            dgvImagenes.DataSource = null;
            dgvImagenes.DataSource = listaLinkImagenes;
            //Oculta las colmnas Id y IdArticulo
            dgvImagenes.Columns["Id"].Visible = false;
            dgvImagenes.Columns["IdArticulo"].Visible = false;
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
            if (dgvImagenes.CurrentRow != null)
            {
                Imagen seleccionado = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Url);
            }
        }
    }
}
