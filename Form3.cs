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
    public partial class ModificarArticulo : Form
    {
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void BTModificarCodigo_Click(object sender, EventArgs e)
        {
            NuevoDato ingresarDato = new NuevoDato();

            ingresarDato.Text = "INGRESE EL NUEVO CODIGO DE ARTICULO";

            ingresarDato.ShowDialog();
        }
    }
}
