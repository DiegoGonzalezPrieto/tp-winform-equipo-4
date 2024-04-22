using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using System.Text.RegularExpressions;

namespace Inventario
{
    public partial class FrmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        public FrmAgregarCategoria()
        {
            InitializeComponent();
        }

        public FrmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            //Categoria categoria = new Categoria();
            CategoriasNegocio leerCategorias = new CategoriasNegocio();

            try
            {
                if(categoria == null) categoria = new Categoria();

                if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
                {

                    categoria.Nombre = txtCategoria.Text;

                    if(categoria.Id != 0)
                    {
                        leerCategorias.modificarCategoria(categoria);
                        MessageBox.Show("Modificado Exitosamente!");
                    }
                    else
                    {
                        leerCategorias.agregarCategoria(categoria);
                        MessageBox.Show("Agregado Exitosamente!");
                    }
                    
                   

                    Close();
                }
                else
                {
                    MessageBox.Show("Ingrese una categoria, no se permiten espacio en blanco o vacios.");
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (Text == "Nueva Categoria")
            {
                LblNuevoDato.Text = "Agregar: ";
            }
            else if (Text == "Modificar Categoria")
            {
                LblNuevoDato.Text = "Modificar: ";
            }

            try
            {
                if (categoria != null)
                {
                   txtCategoria.Text = categoria.Nombre;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
