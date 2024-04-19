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
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            List<Marca> marcas = LeerMarcas.ListaMarcas();
            List<Categoria> categorias = LeerCategorias.ListaCategorias();

            Console.WriteLine("Categorias:");
            Console.WriteLine(categorias.ToString());

            foreach (var item in categorias)
            {
                cmbCategoria.Items.Add(item.Nombre);
            }

            foreach (var item in marcas)
            {
                cmbMarca.Items.Add(item.Nombre);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DatosBusqueda datosBusqueda = new DatosBusqueda();
            // TODO: validar qué datos están en el formulario de búsqueda
            datosBusqueda.CodArticulo = txbCodigoArticulo.Text;

            List<Articulo> resultados = BuscadorArticulos.buscarArticulos(datosBusqueda);

            string res = "";
            foreach (var item in resultados)
            {
                res += item.ToString() + "\n\n";
            }

            MessageBox.Show("Resultados:\n" + res);
        }
    }
}
