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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventario
{
    public partial class AgregarArticulo : Form
    { 
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        public Articulo Articulo { get; set; } = new Articulo();
        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            List<Marca> leerMarcas = MarcasNegocio.ListaMarcas();
            List<Categoria> leerCategorias = CategoriasNegocio.ListaCategorias();

            try
            {
                CBMarca.DataSource = leerMarcas;
                CBMarca.ValueMember = "Id";
                CBMarca.DisplayMember = "Nombre";
                CBMarca.SelectedIndex = -1;
                CBCategoria.DataSource = leerCategorias;
                CBCategoria.ValueMember = "Id";
                CBCategoria.DisplayMember = "Nombre";
                CBCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void ValidarCamposObligatorios()
        {
            if(!lblFaltaCodigo.Visible && !lblFaltaNombre.Visible && !lblFaltaDescripcion.Visible && !lblFaltaMarca.Visible && !lblFaltaCategoria.Visible && !lblFaltaPrecio.Visible)
            { lblCamposObligatorios.Visible = false;}
            else { lblCamposObligatorios.Visible = true; }

        }

        private bool esCodigoNuevo(string nuevoCodigo)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            List <Articulo> listaArticulos = articulosNegocio.listar();

            foreach (Articulo articulo in listaArticulos)
            {
                if (articulo.CodigoArticulo.ToUpper() == nuevoCodigo.ToUpper())
                {
                    return false;

                }
            }

            return true;
        }

        private void BTAgregarArticulo_Click(object sender, EventArgs e)
        {
            if(esCodigoNuevo(TBCodigoArticulo.Text))
            {

            
            if (!lblCamposObligatorios.Visible)
            {

            ArticulosNegocio visu = new ArticulosNegocio();
            try
            {
                Articulo.CodigoArticulo = TBCodigoArticulo.Text.Trim();
                Articulo.Nombre = TBNombre.Text.Trim();
                Articulo.Descripcion = TBDescripcion.Text.Trim();
                Articulo.Marca = (Marca)CBMarca.SelectedItem;
                Articulo.Categoria = (Categoria)CBCategoria.SelectedItem;
                Articulo.Precio = decimal.Parse(TBPrecio.Text.Trim());
                

                visu.agregar(Articulo);
                MessageBox.Show("Agregado Exitosamente!");

                Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Verifique que todos los campos\nesten cargados correctamente.", "Accion No Permitida.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            else
            {

                MessageBox.Show("El código de articulo ingresado ya se encuentra cargado, ingrese un código nuevo.", "Accion No Permitida.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FrmVentanaImagenes ventanaImagenes = new FrmVentanaImagenes())
            {
                ventanaImagenes.ShowDialog();

                if (ventanaImagenes.Resultado == true)
                {
                    Articulo.Imagenes = ventanaImagenes.ListaLinkImagenes.ToList() ;
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
                lblFaltaCodigo.Visible = true ;
                lblCodigoInvalido.Visible = true ;
            } else
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
        private void CBMarca_Leave(object sender, EventArgs e)
        {
            if (CBMarca.SelectedIndex != -1)
            {
                lblFaltaMarca.Visible = false;
            }

            ValidarCamposObligatorios();
        }

        private void CBCategoria_Leave(object sender, EventArgs e)
        {
            if (CBCategoria.SelectedIndex != -1)
            {
                lblFaltaCategoria.Visible = false;
            }

            ValidarCamposObligatorios();
        }


        private void TBPrecio_Leave(object sender, EventArgs e)
        {
            double numero;
            if (!string.IsNullOrEmpty(TBPrecio.Text) && (!double.TryParse(TBPrecio.Text, out numero) || numero<=0))
            {
             
                lblSoloNumeros.Visible = true;
                lblFaltaPrecio.Visible = true;

            } else if (string.IsNullOrEmpty(TBPrecio.Text))
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
