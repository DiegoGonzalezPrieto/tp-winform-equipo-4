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
    public partial class NuevoDato : Form
    {
        public NuevoDato()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("Debe agregar un nombre de Marca correcto.");
            }
            else
            {
                MessageBox.Show("Marca agregado correctamente");
                
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoDato_Load(object sender, EventArgs e)
        {
            if(Text == "Nueva Marca")
            {
                lblNuevoDato.Text = "Agregar: ";

            }else if(Text == "Modificar Marca")
            {
                lblNuevoDato.Text = "Modificar: ";
            }
        }
    }
}
