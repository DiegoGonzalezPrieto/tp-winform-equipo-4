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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 26);
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
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.articuloToolStripMenuItem.Text = "&Articulo";
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.nuevoArticuloToolStripMenuItem.Text = "&Nuevo Articulo";
            this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.nuevoArticuloToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.modificarArticuloToolStripMenuItem.Text = "&Modificar Articulo";
            this.modificarArticuloToolStripMenuItem.Click += new System.EventHandler(this.modificarArticuloToolStripMenuItem_Click);
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.eliminarArticuloToolStripMenuItem.Text = "&Eliminar Articulo";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
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
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.marcaToolStripMenuItem.Text = "&Marca";
            // 
            // nuevaMarcaToolStripMenuItem
            // 
            this.nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
            this.nuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nuevaMarcaToolStripMenuItem.Text = "&Nueva Marca";
            this.nuevaMarcaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMarcaToolStripMenuItem_Click);
            // 
            // modificarMarcaToolStripMenuItem
            // 
            this.modificarMarcaToolStripMenuItem.Name = "modificarMarcaToolStripMenuItem";
            this.modificarMarcaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificarMarcaToolStripMenuItem.Text = "&Modificar Marca";
            this.modificarMarcaToolStripMenuItem.Click += new System.EventHandler(this.modificarMarcaToolStripMenuItem_Click);
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarMarcaToolStripMenuItem.Text = "&Eliminar Marca";
            // 
            // buscarMarcaToolStripMenuItem
            // 
            this.buscarMarcaToolStripMenuItem.Name = "buscarMarcaToolStripMenuItem";
            this.buscarMarcaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
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
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.categoriaToolStripMenuItem.Text = "&Categoria";
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.nuevaCategoriaToolStripMenuItem.Text = "&Nueva Categoria";
            this.nuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCategoriaToolStripMenuItem_Click);
            // 
            // modificarCategoriaToolStripMenuItem
            // 
            this.modificarCategoriaToolStripMenuItem.Name = "modificarCategoriaToolStripMenuItem";
            this.modificarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modificarCategoriaToolStripMenuItem.Text = "&Modificar Categoria";
            this.modificarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.modificarCategoriaToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem1
            // 
            this.eliminarCategoriaToolStripMenuItem1.Name = "eliminarCategoriaToolStripMenuItem1";
            this.eliminarCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.eliminarCategoriaToolStripMenuItem1.Text = "&Eliminar Categoria";
            // 
            // buscarCategoriaToolStripMenuItem1
            // 
            this.buscarCategoriaToolStripMenuItem1.Name = "buscarCategoriaToolStripMenuItem1";
            this.buscarCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.buscarCategoriaToolStripMenuItem1.Text = "&Buscar Categoria";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.editarToolStripMenuItem.Text = "&Ver Articulo";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvArticulos.ColumnHeadersHeight = 29;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(32, 89);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(666, 270);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dataArticulos_SelectionChanged);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(727, 89);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(267, 270);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 2;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 456);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(679, 495);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Artículos v1.0";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvArticulos;
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
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
    }
}

