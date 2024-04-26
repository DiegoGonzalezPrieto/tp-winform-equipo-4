namespace Inventario
{
    partial class FrmVentanaImagenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentanaImagenes));
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.lblImagenesArticulos = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnAgregarLink = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pxbImagenes = new System.Windows.Forms.PictureBox();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.ttpAgregarImagen = new System.Windows.Forms.ToolTip(this.components);
            this.ttpQuitarImagen = new System.Windows.Forms.ToolTip(this.components);
            this.ttpAceptar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpCancelar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.AllowUserToResizeRows = false;
            this.dgvImagenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenes.Location = new System.Drawing.Point(9, 62);
            this.dgvImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.RowHeadersVisible = false;
            this.dgvImagenes.RowHeadersWidth = 51;
            this.dgvImagenes.RowTemplate.Height = 24;
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(368, 204);
            this.dgvImagenes.TabIndex = 0;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // lblImagenesArticulos
            // 
            this.lblImagenesArticulos.AutoSize = true;
            this.lblImagenesArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenesArticulos.Location = new System.Drawing.Point(6, 31);
            this.lblImagenesArticulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenesArticulos.Name = "lblImagenesArticulos";
            this.lblImagenesArticulos.Size = new System.Drawing.Size(111, 18);
            this.lblImagenesArticulos.TabIndex = 1;
            this.lblImagenesArticulos.Text = "Link de imagen:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(112, 29);
            this.txtLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(201, 23);
            this.txtLink.TabIndex = 2;
            // 
            // btnAgregarLink
            // 
            this.btnAgregarLink.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLink.Image")));
            this.btnAgregarLink.Location = new System.Drawing.Point(323, 24);
            this.btnAgregarLink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarLink.Name = "btnAgregarLink";
            this.btnAgregarLink.Size = new System.Drawing.Size(53, 33);
            this.btnAgregarLink.TabIndex = 3;
            this.ttpAgregarImagen.SetToolTip(this.btnAgregarLink, "Agregar imagen");
            this.btnAgregarLink.UseVisualStyleBackColor = true;
            this.btnAgregarLink.Click += new System.EventHandler(this.btnAgregarLink_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(268, 271);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(45, 41);
            this.btnAceptar.TabIndex = 4;
            this.ttpAceptar.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(332, 271);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 41);
            this.btnCancel.TabIndex = 5;
            this.ttpCancelar.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pxbImagenes
            // 
            this.pxbImagenes.Location = new System.Drawing.Point(396, 62);
            this.pxbImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pxbImagenes.Name = "pxbImagenes";
            this.pxbImagenes.Size = new System.Drawing.Size(236, 204);
            this.pxbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbImagenes.TabIndex = 6;
            this.pxbImagenes.TabStop = false;
            this.pxbImagenes.Paint += new System.Windows.Forms.PaintEventHandler(this.pxbImagenes_Paint);
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarImagen.Image")));
            this.btnQuitarImagen.Location = new System.Drawing.Point(19, 271);
            this.btnQuitarImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(45, 41);
            this.btnQuitarImagen.TabIndex = 7;
            this.ttpQuitarImagen.SetToolTip(this.btnQuitarImagen, "Quitar imagen");
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);
            // 
            // FrmVentanaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 327);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.pxbImagenes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblImagenesArticulos);
            this.Controls.Add(this.dgvImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentanaImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.FrmVentanaImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.Label lblImagenesArticulos;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnAgregarLink;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pxbImagenes;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.ToolTip ttpAgregarImagen;
        private System.Windows.Forms.ToolTip ttpAceptar;
        private System.Windows.Forms.ToolTip ttpCancelar;
        private System.Windows.Forms.ToolTip ttpQuitarImagen;
    }
}