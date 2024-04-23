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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentanaImagenes));
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.lblImagenesArticulos = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnAgregarLink = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pxbImagenes = new System.Windows.Forms.PictureBox();
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
            this.dgvImagenes.Location = new System.Drawing.Point(12, 76);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.RowHeadersVisible = false;
            this.dgvImagenes.RowHeadersWidth = 51;
            this.dgvImagenes.RowTemplate.Height = 24;
            this.dgvImagenes.Size = new System.Drawing.Size(490, 251);
            this.dgvImagenes.TabIndex = 0;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // lblImagenesArticulos
            // 
            this.lblImagenesArticulos.AutoSize = true;
            this.lblImagenesArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenesArticulos.Location = new System.Drawing.Point(8, 38);
            this.lblImagenesArticulos.Name = "lblImagenesArticulos";
            this.lblImagenesArticulos.Size = new System.Drawing.Size(136, 22);
            this.lblImagenesArticulos.TabIndex = 1;
            this.lblImagenesArticulos.Text = "Link de imagen:";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(150, 36);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(267, 27);
            this.txtLink.TabIndex = 2;
            // 
            // btnAgregarLink
            // 
            this.btnAgregarLink.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLink.Image")));
            this.btnAgregarLink.Location = new System.Drawing.Point(431, 29);
            this.btnAgregarLink.Name = "btnAgregarLink";
            this.btnAgregarLink.Size = new System.Drawing.Size(71, 41);
            this.btnAgregarLink.TabIndex = 3;
            this.btnAgregarLink.UseVisualStyleBackColor = true;
            this.btnAgregarLink.Click += new System.EventHandler(this.btnAgregarLink_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(357, 333);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 50);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(442, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 50);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pxbImagenes
            // 
            this.pxbImagenes.Location = new System.Drawing.Point(528, 76);
            this.pxbImagenes.Name = "pxbImagenes";
            this.pxbImagenes.Size = new System.Drawing.Size(314, 251);
            this.pxbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbImagenes.TabIndex = 6;
            this.pxbImagenes.TabStop = false;
            // 
            // FrmVentanaImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 403);
            this.Controls.Add(this.pxbImagenes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarLink);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.lblImagenesArticulos);
            this.Controls.Add(this.dgvImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}