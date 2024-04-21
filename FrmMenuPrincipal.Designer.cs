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
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCategoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.articuloToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(912, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.articuloToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.articuloToolStripMenuItem.Text = "&Articulo";
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.nuevoArticuloToolStripMenuItem.Text = "&Nuevo Articulo";
            this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.nuevoArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.modificarArticuloToolStripMenuItem.Text = "&Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.eliminarArticuloToolStripMenuItem.Text = "&Eliminar Articulo";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.buscarToolStripMenuItem.Text = "&Buscar Articulo";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMarcaToolStripMenuItem,
            this.modificarMarcaToolStripMenuItem,
            this.eliminarMarcaToolStripMenuItem,
            this.buscarMarcaToolStripMenuItem});
            this.marcaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.marcaToolStripMenuItem.Text = "&Marca";
            // 
            // nuevaMarcaToolStripMenuItem
            // 
            this.nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
            this.nuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nuevaMarcaToolStripMenuItem.Text = "&Nueva Marca";
            this.nuevaMarcaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMarcaToolStripMenuItem_Click);
            // 
            // modificarMarcaToolStripMenuItem
            // 
            this.modificarMarcaToolStripMenuItem.Name = "modificarMarcaToolStripMenuItem";
            this.modificarMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.modificarMarcaToolStripMenuItem.Text = "&Modificar Marca";
            this.modificarMarcaToolStripMenuItem.Click += new System.EventHandler(this.modificarMarcaToolStripMenuItem_Click);
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.eliminarMarcaToolStripMenuItem.Text = "&Eliminar Marca";
            // 
            // buscarMarcaToolStripMenuItem
            // 
            this.buscarMarcaToolStripMenuItem.Name = "buscarMarcaToolStripMenuItem";
            this.buscarMarcaToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.buscarMarcaToolStripMenuItem.Text = "&Buscar Marca";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCategoriaToolStripMenuItem,
            this.modificarCategoriaToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem1,
            this.buscarCategoriaToolStripMenuItem1});
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(98, 26);
            this.categoriaToolStripMenuItem.Text = "&Categoria";
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.nuevaCategoriaToolStripMenuItem.Text = "&Nueva Categoria";
            this.nuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCategoriaToolStripMenuItem_Click);
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.modificarCategoriaToolStripMenuItem.Text = "&Modificar Categoria";
            this.modificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem1
            // 
            this.eliminarCategoriaToolStripMenuItem1.Name = "eliminarCategoriaToolStripMenuItem1";
            this.eliminarCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.eliminarCategoriaToolStripMenuItem1.Text = "&Eliminar Categoria";
            // 
            // buscarCategoriaToolStripMenuItem1
            // 
            this.buscarCategoriaToolStripMenuItem1.Name = "buscarCategoriaToolStripMenuItem1";
            this.buscarCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.buscarCategoriaToolStripMenuItem1.Text = "&Buscar Categoria";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.editarToolStripMenuItem.Text = "&Ver Articulo";
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
            this.dataArticulos.Location = new System.Drawing.Point(12, 109);
            this.dataArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataArticulos.Name = "dataArticulos";
            this.dataArticulos.RowHeadersWidth = 51;
            this.dataArticulos.RowTemplate.Height = 24;
            this.dataArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataArticulos.Size = new System.Drawing.Size(888, 332);
            this.dataArticulos.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 553);
            this.Controls.Add(this.dataArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
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
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataArticulos;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarCategoriaToolStripMenuItem1;
    }
}

