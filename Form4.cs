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
            Marca marca = new Marca();
            try
            {
                marca.Nombre = txtMarca.Text;

                Data datos = new Data();

                try
                {
                    datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES('" + marca.Nombre + "')");
                    datos.ejecutarLectura();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }

                MessageBox.Show("Agregado Exitosamente!");

                Close();

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
