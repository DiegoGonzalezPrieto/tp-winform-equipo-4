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
using static System.Net.Mime.MediaTypeNames;

namespace Inventario
{
    public partial class FrmVerArticulo : Form
    {
        private Articulo articulo = null;
        public FrmVerArticulo()
        {
            InitializeComponent();
        }

        public FrmVerArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }

        private void FrmVerArticulo_Load(object sender, EventArgs e)
        {
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString("F2");
            lblMarca.Text = articulo.Marca.Nombre;
            lblCategoria.Text = articulo.Categoria.Nombre;
            if (articulo.Imagenes.Count > 0)
                obtenerImagenDetalleArticulo(articulo.Imagenes[0]);
            else
                obtenerImagenDetalleArticulo(null);



        }

        private void PBImagenDetalle_Click(object sender, EventArgs e)
        {

        }

        private void obtenerImagenDetalleArticulo(Imagen imagen)
        {
            // si no tiene imagenes, cargar placeholder y volver
            if (imagen == null)
            {
                PBImagenDetalle.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
                return;
            }

            try
            {
                PBImagenDetalle.Load(imagen.Url);
            }
            catch (Exception)
            {
                PBImagenDetalle.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
                //pbxImagenArticulo.Load("https://bcs-management.com/wp-content/uploads/2017/02/2000px-No_image_available.svg_-1024x1024.png");
                //pbxImagenArticulo.Load("https://placehold.co/600x400@2x.png?text=%F0%9F%98%85");
            }


        }
        /*
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes.Count == 0)
                return;

            try
            {
                string urlImagen = PBImagenDetalle.ImageLocation;
                int indiceActual = articulo.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual < articulo.Imagenes.Count - 1)
                {
                    obtenerImagenDetalleArticulo(articulo.Imagenes[indiceActual + 1]);
                }
                else
                {
                    // ir a imagen inicial
                    obtenerImagenDetalleArticulo(articulo.Imagenes[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes.Count == 0)
                return;

            try
            {
                string urlImagen = PBImagenDetalle.ImageLocation;
                int indiceActual = articulo.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual == 0)
                {
                    int cantImagenes = articulo.Imagenes.Count;
                    obtenerImagenDetalleArticulo(articulo.Imagenes[cantImagenes - 1]);
                }
                else
                {
                    // ir imagen final
                    obtenerImagenDetalleArticulo(articulo.Imagenes[indiceActual - 1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        */
        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes.Count == 0)
                return;

            try
            {
                string urlImagen = PBImagenDetalle.ImageLocation;
                int indiceActual = articulo.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual < articulo.Imagenes.Count - 1)
                {
                    obtenerImagenDetalleArticulo(articulo.Imagenes[indiceActual + 1]);
                }
                else
                {
                    // ir a imagen inicial
                    obtenerImagenDetalleArticulo(articulo.Imagenes[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void lblAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes.Count == 0)
                return;
                

            try
            {
                string urlImagen = PBImagenDetalle.ImageLocation;
                int indiceActual = articulo.Imagenes.FindIndex(i => i.Url == urlImagen);

                if (indiceActual > 0)
                
                {
                    int cantImagenes = articulo.Imagenes.Count;
                    
                    obtenerImagenDetalleArticulo(articulo.Imagenes[articulo.Imagenes.Count - 1]);
                }
                else
                {
                    // ir imagen final
                    
                    obtenerImagenDetalleArticulo(articulo.Imagenes[articulo.Imagenes.Count - 1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
    }
}
