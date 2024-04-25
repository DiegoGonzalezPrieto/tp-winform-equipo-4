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
            //Articulo articulo = new Articulo();
            ArticulosNegocio visu = new ArticulosNegocio();

            try
            {
                Articulo.CodigoArticulo = TBCodigoArticulo.Text;
                Articulo.Nombre = TBNombre.Text;
                Articulo.Descripcion = TBDescripcion.Text;
                Articulo.Marca = (Marca)CBMarca.SelectedItem;
                Articulo.Categoria = (Categoria)CBCategoria.SelectedItem;
                Articulo.Precio = decimal.Parse(TBPrecio.Text);
                

                visu.agregar(Articulo);
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
            using (FrmVentanaImagenes ventanaImagenes = new FrmVentanaImagenes())
            {
                ventanaImagenes.ShowDialog();

                if (ventanaImagenes.Resultado == true)
                {
                    Articulo.Imagenes = ventanaImagenes.ListaLinkImagenes.ToList() ;
                }
            }
            
        }

        private void lblAgregarArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio visu = new ArticulosNegocio();

            try
            {
                Articulo.CodigoArticulo = TBCodigoArticulo.Text;
                Articulo.Nombre = TBNombre.Text;
                Articulo.Descripcion = TBDescripcion.Text;
                Articulo.Marca = (Marca)CBMarca.SelectedItem;
                Articulo.Categoria = (Categoria)CBCategoria.SelectedItem;
                Articulo.Precio = decimal.Parse(TBPrecio.Text);


                visu.agregar(Articulo);
                MessageBox.Show("Agregado Exitosamente!");

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifique que los campos esten cargados correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
