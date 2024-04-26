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
using System.Xml.Linq;


namespace Inventario
{
    public partial class ModificarArticulo : Form
    {
        private Articulo articulo;
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        public ModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            List<Marca> marcasNegocio = MarcasNegocio.ListaMarcas();
            List<Categoria> categoriasNegocio = CategoriasNegocio.ListaCategorias();

            try
            {
                cbMarca.DataSource = marcasNegocio;
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Nombre";
                cbCategoria.DataSource = categoriasNegocio;
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Nombre";

                if(articulo != null)
                {
                    TBCodigoArticulo.Text = articulo.CodigoArticulo;
                    TBNombre.Text = articulo.Nombre;
                    TBDescripcion.Text = articulo.Descripcion;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    TBPrecio.Text = articulo.Precio.ToString();
                }
               

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
            

        }

        private void BTGuardarArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (articulo == null) articulo = new Articulo();

                articulo.CodigoArticulo = TBCodigoArticulo.Text;
                articulo.Nombre = TBNombre.Text;
                articulo.Descripcion = TBDescripcion.Text;
               
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;

                articulo.Precio = decimal.Parse(TBPrecio.Text);

                
                negocio.modificar(articulo);
                MessageBox.Show("Modificado Exitosamente!");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarImagenes_Click(object sender, EventArgs e)
        {
            using (FrmVentanaImagenes ventanaImagenes = new FrmVentanaImagenes(articulo.Imagenes))
            {
                ventanaImagenes.ShowDialog();

                if (ventanaImagenes.Resultado == true)
                {
                    articulo.Imagenes = ventanaImagenes.ListaLinkImagenes.ToList();
                }
            }
        }
    }
}
