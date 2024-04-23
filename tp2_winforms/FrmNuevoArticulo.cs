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
    public partial class AgregarArticulo : Form
    { 
        public AgregarArticulo()
        {
            InitializeComponent();

        }
        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            List<Marca> leerMarcas = MarcasNegocio.ListaMarcas();
            List<Categoria> leerCategorias = CategoriasNegocio.ListaCategorias();

            try
            {
                CBMarca.DataSource = leerMarcas;
                CBMarca.ValueMember = "Id";
                CBMarca.DisplayMember = "Nombre";
                CBCategoria.DataSource = leerCategorias;
                CBCategoria.ValueMember = "Id";
                CBCategoria.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void TBCodigoArticulo_TextChanged(object sender, EventArgs e)
        {
        }
        private void TBNombre_TextChanged(object sender, EventArgs e)
        {
        }
        private void TBDescripcion_TextChanged(object sender, EventArgs e)
        {
        }

        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void BTAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticulosNegocio visu = new ArticulosNegocio();

            try
            {
                articulo.CodigoArticulo = TBCodigoArticulo.Text;
                articulo.Nombre = TBNombre.Text;
                articulo.Descripcion = TBDescripcion.Text;
                articulo.Marca = (Marca)CBMarca.SelectedItem;
                articulo.Categoria = (Categoria)CBCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(TBPrecio.Text);
                

                visu.agregar(articulo);
                MessageBox.Show("Agregado Exitosamente!");

                Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Verifique que los campos esten cargados correctamente.");
            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.ToString());
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmVentanaImagenes ventanaImagenes = new FrmVentanaImagenes();
            ventanaImagenes.ShowDialog();
        }
    }
}
