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
    public partial class FrmAgregarMarca : Form
    {
        private Marca marca = null;
        public FrmAgregarMarca()
        {
            InitializeComponent();
        }

        public FrmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void btnGuardarMarca_Click(object sender, EventArgs e)
        {
            //Marca marca = new Marca();
            MarcasNegocio leerMarcas = new MarcasNegocio();
            try
            {
                if (marca == null) marca = new Marca();

                if(!string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    marca.Nombre = txtMarca.Text.Trim();


                    if(marca.Id != 0)
                    {
                        leerMarcas.modificar(marca);
                        MessageBox.Show("Modificado Exitosamente!");
                    }
                    else
                    {
                        leerMarcas.agregarMarca(marca);
                        MessageBox.Show("Agregado Exitosamente!");
                       
                        
                    }
                    

                    

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
            try
            {
                if (marca != null)
                {
                    txtMarca.Text = marca.Nombre;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


    }
}
