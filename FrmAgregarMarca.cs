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
    public partial class FrmAgregarMarca : Form
    {
        public FrmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            LeerMarcas leerMarcas = new LeerMarcas();
            try
            {
                if(!string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    marca.Nombre = txtMarca.Text;
                    leerMarcas.agregarMarca(marca);

                    MessageBox.Show("Agregado Exitosamente!");

                    Close();
                }else
                {
                    MessageBox.Show("Ingrese una marca, no se permiten espacio en blanco o vacios.");
                }
                //marca.Nombre = txtMarca.Text;

                

            }
            catch (Exception ex)
            {

                throw ex;
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
