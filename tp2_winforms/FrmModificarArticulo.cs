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

        private void ValidarCamposObligatorios()
        {
            if (!lblFaltaCodigo.Visible && !lblFaltaNombre.Visible && !lblFaltaDescripcion.Visible && !lblFaltaPrecio.Visible)
            { lblCamposObligatorios.Visible = false; }
            else { lblCamposObligatorios.Visible = true; }

        }
        private void BTGuardarArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();

            if(!lblCamposObligatorios.Visible)
            {

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
            else
            {
                MessageBox.Show("Verifique que todos los campos\nesten cargados correctamente.", "Accion No Permitida.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private bool esCodigoValido(string codigo)
        {
            if (codigo.Length != 3 || !char.IsLetter(codigo[0]) || !char.IsDigit(codigo[1]) || !char.IsDigit(codigo[2]))
            {
                return false;
            }
            return true;
        }
        private void TBCodigoArticulo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBCodigoArticulo.Text))
            {
                lblFaltaCodigo.Visible = true;
                lblCodigoInvalido.Visible = false;
            }
            else if (!esCodigoValido(TBCodigoArticulo.Text))
            {
                lblFaltaCodigo.Visible = true;
                lblCodigoInvalido.Visible = true;
            }
            else
            {
                lblFaltaCodigo.Visible = false;
                lblCodigoInvalido.Visible = false;
            }

            ValidarCamposObligatorios();
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBNombre.Text))
            {
                lblFaltaNombre.Visible = true;
            }
            else
            {
                lblFaltaNombre.Visible = false;
            }

            ValidarCamposObligatorios();
        }

        private void TBDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDescripcion.Text))
            {
                lblFaltaDescripcion.Visible = true;
            }
            else
            {
                lblFaltaDescripcion.Visible = false;
            }

            ValidarCamposObligatorios();
        }

        private void TBPrecio_Leave(object sender, EventArgs e)
        {
            double numero;

            if (!string.IsNullOrEmpty(TBPrecio.Text) && (!double.TryParse(TBPrecio.Text, out numero) || numero <= 0))
            {
                lblSoloNumeros.Visible = true;
                lblFaltaPrecio.Visible = true;

            }
            else if (string.IsNullOrEmpty(TBPrecio.Text))
            {
                lblFaltaPrecio.Visible = true;
                lblSoloNumeros.Visible = false;
            }
            else
            {
                lblFaltaPrecio.Visible = false;
                lblSoloNumeros.Visible = false;
            }

            ValidarCamposObligatorios();
        }

    }
}
