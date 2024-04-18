using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();

            CBMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void AgregarArticulo_Load(object sender, EventArgs e)
        {

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

        private void CBMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void BTAgregarArticulo_Click(object sender, EventArgs e)
        {

        if (TBCodigoArticulo.TextLength > 0 &&
        TBNombre.TextLength > 0 &&
        TBDescripcion.TextLength > 0 &&
        CBMarca.SelectedIndex != -1 &&
        CBCategoria.SelectedIndex != -1)
            {
                string codigoArticulo = TBCodigoArticulo.Text;
                string nombre = TBNombre.Text;
                string descripcion = TBDescripcion.Text;
                int marca = CBMarca.SelectedIndex;
                int categoria = CBCategoria.SelectedIndex;

                MessageBox.Show("ID: (ID asignado)" + "\nCodigo de articulo: " + codigoArticulo.ToString() + "\nNombre: " + nombre.ToString() + "\nDescripcion: " + descripcion.ToString() + "\nMarca: " + marca.ToString() + "\nCategoria: " + categoria.ToString(), "Articulo cargado correctamente");
            }
            else { MessageBox.Show("Debe completar todos los campos para poder guardar un articulo"); }
        }


    }
}
