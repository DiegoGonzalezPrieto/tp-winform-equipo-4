namespace Inventario
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.Articulo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.Marca = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.Categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataArticulos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsInicio,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(932, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsInicio
            // 
            this.tlsInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Articulo,
            this.Marca,
            this.Categoria,
            this.tlsBuscar});
            this.tlsInicio.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsInicio.Name = "tlsInicio";
            this.tlsInicio.Size = new System.Drawing.Size(67, 26);
            this.tlsInicio.Text = "&Inicio";
            // 
            // Articulo
            // 
            this.Articulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArticulo,
            this.modificarArticulo,
            this.eliminarArticulo,
            this.buscarArticulo});
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(224, 26);
            this.Articulo.Text = "&Articulo";
            // 
            // nuevoArticulo
            // 
            this.nuevoArticulo.Name = "nuevoArticulo";
            this.nuevoArticulo.Size = new System.Drawing.Size(230, 26);
            this.nuevoArticulo.Text = "&Nuevo Articulo";
            this.nuevoArticulo.Click += new System.EventHandler(this.nuevoArticulo_Click);
            // 
            // modificarArticulo
            // 
            this.modificarArticulo.Name = "modificarArticulo";
            this.modificarArticulo.Size = new System.Drawing.Size(230, 26);
            this.modificarArticulo.Text = "&Modificar Articulo";
            // 
            // eliminarArticulo
            // 
            this.eliminarArticulo.Name = "eliminarArticulo";
            this.eliminarArticulo.Size = new System.Drawing.Size(230, 26);
            this.eliminarArticulo.Text = "&Eliminar Articulo";
            // 
            // buscarArticulo
            // 
            this.buscarArticulo.Name = "buscarArticulo";
            this.buscarArticulo.Size = new System.Drawing.Size(230, 26);
            this.buscarArticulo.Text = "&Buscar Articulo";
            // 
            // Marca
            // 
            this.Marca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMarca,
            this.modificarMarca,
            this.eliminarMarca,
            this.buscarMarca});
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(224, 26);
            this.Marca.Text = "&Marca";
            // 
            // nuevaMarca
            // 
            this.nuevaMarca.Name = "nuevaMarca";
            this.nuevaMarca.Size = new System.Drawing.Size(224, 26);
            this.nuevaMarca.Text = "&Nueva Marca";
            this.nuevaMarca.Click += new System.EventHandler(this.nuevaMarca_Click);
            // 
            // modificarMarca
            // 
            this.modificarMarca.Name = "modificarMarca";
            this.modificarMarca.Size = new System.Drawing.Size(224, 26);
            this.modificarMarca.Text = "&Modificar Marca";
            this.modificarMarca.Click += new System.EventHandler(this.modificarMarca_Click);
            // 
            // eliminarMarca
            // 
            this.eliminarMarca.Name = "eliminarMarca";
            this.eliminarMarca.Size = new System.Drawing.Size(224, 26);
            this.eliminarMarca.Text = "&Eliminar Marca";
            // 
            // buscarMarca
            // 
            this.buscarMarca.Name = "buscarMarca";
            this.buscarMarca.Size = new System.Drawing.Size(224, 26);
            this.buscarMarca.Text = "&Buscar Marca";
            // 
            // Categoria
            // 
            this.Categoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCategoria,
            this.modificarCategoria,
            this.eliminarCategoriaToolStripMenuItem,
            this.buscarCategoriaToolStripMenuItem});
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(224, 26);
            this.Categoria.Text = "&Categoria";
            // 
            // nuevaCategoria
            // 
            this.nuevaCategoria.Name = "nuevaCategoria";
            this.nuevaCategoria.Size = new System.Drawing.Size(245, 26);
            this.nuevaCategoria.Text = "&Nueva Categoria";
            // 
            // modificarCategoria
            // 
            this.modificarCategoria.Name = "modificarCategoria";
            this.modificarCategoria.Size = new System.Drawing.Size(245, 26);
            this.modificarCategoria.Text = "&Modificar Categoria";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.eliminarCategoriaToolStripMenuItem.Text = "&Eliminar Categoria";
            // 
            // buscarCategoriaToolStripMenuItem
            // 
            this.buscarCategoriaToolStripMenuItem.Name = "buscarCategoriaToolStripMenuItem";
            this.buscarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.buscarCategoriaToolStripMenuItem.Text = "&Buscar Categoria";
            // 
            // tlsBuscar
            // 
            this.tlsBuscar.Name = "tlsBuscar";
            this.tlsBuscar.Size = new System.Drawing.Size(224, 26);
            this.tlsBuscar.Text = "&Buscar Articulo";
            this.tlsBuscar.Click += new System.EventHandler(this.buscarArticuloToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.editarToolStripMenuItem.Text = "&Ver";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // dataArticulos
            // 
            this.dataArticulos.AllowUserToResizeColumns = false;
            this.dataArticulos.AllowUserToResizeRows = false;
            this.dataArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataArticulos.ColumnHeadersHeight = 29;
            this.dataArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataArticulos.Location = new System.Drawing.Point(26, 95);
            this.dataArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataArticulos.Name = "dataArticulos";
            this.dataArticulos.RowHeadersWidth = 51;
            this.dataArticulos.RowTemplate.Height = 24;
            this.dataArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataArticulos.Size = new System.Drawing.Size(874, 332);
            this.dataArticulos.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.dataArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos v1.0";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsInicio;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Articulo;
        private System.Windows.Forms.ToolStripMenuItem Marca;
        private System.Windows.Forms.ToolStripMenuItem Categoria;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscar;
        private System.Windows.Forms.DataGridView dataArticulos;
        private System.Windows.Forms.ToolStripMenuItem nuevaMarca;
        private System.Windows.Forms.ToolStripMenuItem modificarMarca;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem buscarMarca;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticulo;
        private System.Windows.Forms.ToolStripMenuItem modificarArticulo;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem buscarArticulo;
        private System.Windows.Forms.ToolStripMenuItem nuevaCategoria;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoria;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCategoriaToolStripMenuItem;
    }
}

