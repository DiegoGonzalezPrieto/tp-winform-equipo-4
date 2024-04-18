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
            this.tlsNuevoArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsActualizarArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRUEBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEliminarArticulo = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(882, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsInicio
            // 
            this.tlsInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsNuevoArticulo,
            this.tlsActualizarArticulo,
            this.tlsEliminarArticulo,
            this.tlsBuscar});
            this.tlsInicio.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsInicio.Name = "tlsInicio";
            this.tlsInicio.Size = new System.Drawing.Size(67, 26);
            this.tlsInicio.Text = "&Inicio";
            // 
            // tlsNuevoArticulo
            // 
            this.tlsNuevoArticulo.Name = "tlsNuevoArticulo";
            this.tlsNuevoArticulo.Size = new System.Drawing.Size(230, 26);
            this.tlsNuevoArticulo.Text = "&Nuevo Articulo";
            this.tlsNuevoArticulo.Click += new System.EventHandler(this.tlsNuevoArticulo_Click);
            // 
            // tlsActualizarArticulo
            // 
            this.tlsActualizarArticulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarPorIDToolStripMenuItem,
            this.seleccionarPorCategoriaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.seleccionarPorMarcaToolStripMenuItem,
            this.pRUEBAToolStripMenuItem});
            this.tlsActualizarArticulo.Name = "tlsActualizarArticulo";
            this.tlsActualizarArticulo.Size = new System.Drawing.Size(230, 26);
            this.tlsActualizarArticulo.Text = "&Modificar Articulo";
            // 
            // seleccionarPorIDToolStripMenuItem
            // 
            this.seleccionarPorIDToolStripMenuItem.Name = "seleccionarPorIDToolStripMenuItem";
            this.seleccionarPorIDToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.seleccionarPorIDToolStripMenuItem.Text = "Seleccionar por ID";
            // 
            // seleccionarPorCategoriaToolStripMenuItem
            // 
            this.seleccionarPorCategoriaToolStripMenuItem.Name = "seleccionarPorCategoriaToolStripMenuItem";
            this.seleccionarPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.seleccionarPorCategoriaToolStripMenuItem.Text = "Seleccionar por código";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(290, 26);
            this.toolStripMenuItem1.Text = "Seleccionar por categoria";
            // 
            // seleccionarPorMarcaToolStripMenuItem
            // 
            this.seleccionarPorMarcaToolStripMenuItem.Name = "seleccionarPorMarcaToolStripMenuItem";
            this.seleccionarPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.seleccionarPorMarcaToolStripMenuItem.Text = "Seleccionar por marca";
            // 
            // pRUEBAToolStripMenuItem
            // 
            this.pRUEBAToolStripMenuItem.Name = "pRUEBAToolStripMenuItem";
            this.pRUEBAToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.pRUEBAToolStripMenuItem.Text = "Prueba";
            this.pRUEBAToolStripMenuItem.Click += new System.EventHandler(this.pRUEBAToolStripMenuItem_Click);
            // 
            // tlsEliminarArticulo
            // 
            this.tlsEliminarArticulo.Name = "tlsEliminarArticulo";
            this.tlsEliminarArticulo.Size = new System.Drawing.Size(230, 26);
            this.tlsEliminarArticulo.Text = "&Eliminar Articulo";
            // 
            // tlsBuscar
            // 
            this.tlsBuscar.Name = "tlsBuscar";
            this.tlsBuscar.Size = new System.Drawing.Size(230, 26);
            this.tlsBuscar.Text = "&Buscar Articulo";
            this.tlsBuscar.Click += new System.EventHandler(this.buscarArticuloToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(50, 26);
            this.editarToolStripMenuItem.Text = "Ver";
            // 
            // dataArticulos
            // 
            this.dataArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataArticulos.Location = new System.Drawing.Point(12, 80);
            this.dataArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataArticulos.Name = "dataArticulos";
            this.dataArticulos.RowHeadersWidth = 51;
            this.dataArticulos.RowTemplate.Height = 24;
            this.dataArticulos.Size = new System.Drawing.Size(858, 332);
            this.dataArticulos.TabIndex = 1;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
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
        private System.Windows.Forms.ToolStripMenuItem tlsInicio;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsNuevoArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsActualizarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsEliminarArticulo;
        private System.Windows.Forms.ToolStripMenuItem tlsBuscar;
        private System.Windows.Forms.DataGridView dataArticulos;
        private System.Windows.Forms.ToolStripMenuItem seleccionarPorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleccionarPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRUEBAToolStripMenuItem;
    }
}

