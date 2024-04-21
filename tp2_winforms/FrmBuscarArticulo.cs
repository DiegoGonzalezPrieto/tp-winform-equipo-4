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
    public partial class FrmBuscarArticulo : Form
    {
        public FrmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            FrmAgregarMarca modificarMarca = new FrmAgregarMarca();
            modificarMarca.Text = "Modificar Marca";
            modificarMarca.ShowDialog();
        }
    }
}
