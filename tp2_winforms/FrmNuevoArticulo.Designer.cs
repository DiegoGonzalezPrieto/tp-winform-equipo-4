namespace Inventario
{
    partial class AgregarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarArticulo));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBCodigoArticulo = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.BTAgregarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarImagenes = new System.Windows.Forms.Button();
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblFaltaCodigo = new System.Windows.Forms.Label();
            this.lblFaltaNombre = new System.Windows.Forms.Label();
            this.lblFaltaDescripcion = new System.Windows.Forms.Label();
            this.lblFaltaMarca = new System.Windows.Forms.Label();
            this.lblFaltaCategoria = new System.Windows.Forms.Label();
            this.lblFaltaPrecio = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoría:";
            // 
            // TBCodigoArticulo
            // 
            this.TBCodigoArticulo.AccessibleName = "";
            this.TBCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoArticulo.Location = new System.Drawing.Point(226, 32);
            this.TBCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCodigoArticulo.MaxLength = 4;
            this.TBCodigoArticulo.Name = "TBCodigoArticulo";
            this.TBCodigoArticulo.Size = new System.Drawing.Size(200, 27);
            this.TBCodigoArticulo.TabIndex = 0;
            this.TBCodigoArticulo.Leave += new System.EventHandler(this.TBCodigoArticulo_Leave);
            // 
            // TBNombre
            // 
            this.TBNombre.AccessibleName = "";
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(226, 87);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombre.MaxLength = 50;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(200, 27);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.Tag = "";
            this.TBNombre.Leave += new System.EventHandler(this.TBNombre_Leave);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(226, 142);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDescripcion.MaxLength = 100;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(200, 27);
            this.TBDescripcion.TabIndex = 2;
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // CBMarca
            // 
            this.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBMarca.Location = new System.Drawing.Point(226, 196);
            this.CBMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBMarca.MaxLength = 2;
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(200, 28);
            this.CBMarca.TabIndex = 3;
            this.CBMarca.Click += new System.EventHandler(this.CBMarca_Click);
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CBCategoria.Location = new System.Drawing.Point(226, 252);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBCategoria.MaxLength = 2;
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(200, 28);
            this.CBCategoria.TabIndex = 4;
            this.CBCategoria.Click += new System.EventHandler(this.CBCategoria_Click);
            // 
            // BTAgregarArticulo
            // 
            this.BTAgregarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarArticulo.Location = new System.Drawing.Point(122, 425);
            this.BTAgregarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTAgregarArticulo.Name = "BTAgregarArticulo";
            this.BTAgregarArticulo.Size = new System.Drawing.Size(233, 36);
            this.BTAgregarArticulo.TabIndex = 6;
            this.BTAgregarArticulo.Text = "Agregar Artículo";
            this.BTAgregarArticulo.UseVisualStyleBackColor = true;
            this.BTAgregarArticulo.Click += new System.EventHandler(this.BTAgregarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(130, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Precio:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio.Location = new System.Drawing.Point(226, 361);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrecio.MaxLength = 8;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(200, 27);
            this.TBPrecio.TabIndex = 5;
            this.TBPrecio.Leave += new System.EventHandler(this.TBPrecio_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(99, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Imágenes:";
            // 
            // btnAgregarImagenes
            // 
            this.btnAgregarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagenes.Location = new System.Drawing.Point(226, 305);
            this.btnAgregarImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarImagenes.Name = "btnAgregarImagenes";
            this.btnAgregarImagenes.Size = new System.Drawing.Size(200, 34);
            this.btnAgregarImagenes.TabIndex = 14;
            this.btnAgregarImagenes.Text = "Agregar";
            this.btnAgregarImagenes.UseVisualStyleBackColor = true;
            this.btnAgregarImagenes.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("lblAgregarArticulo.Image")));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(359, 418);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(50, 50);
            this.lblAgregarArticulo.TabIndex = 15;
            this.lblAgregarArticulo.Text = "  ";
            // 
            // lblFaltaCodigo
            // 
            this.lblFaltaCodigo.AutoSize = true;
            this.lblFaltaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaCodigo.Location = new System.Drawing.Point(432, 35);
            this.lblFaltaCodigo.Name = "lblFaltaCodigo";
            this.lblFaltaCodigo.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaCodigo.TabIndex = 16;
            this.lblFaltaCodigo.Text = "*";
            // 
            // lblFaltaNombre
            // 
            this.lblFaltaNombre.AutoSize = true;
            this.lblFaltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaNombre.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaNombre.Location = new System.Drawing.Point(432, 91);
            this.lblFaltaNombre.Name = "lblFaltaNombre";
            this.lblFaltaNombre.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaNombre.TabIndex = 17;
            this.lblFaltaNombre.Text = "*";
            // 
            // lblFaltaDescripcion
            // 
            this.lblFaltaDescripcion.AutoSize = true;
            this.lblFaltaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaDescripcion.Location = new System.Drawing.Point(432, 145);
            this.lblFaltaDescripcion.Name = "lblFaltaDescripcion";
            this.lblFaltaDescripcion.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaDescripcion.TabIndex = 18;
            this.lblFaltaDescripcion.Text = "*";
            // 
            // lblFaltaMarca
            // 
            this.lblFaltaMarca.AutoSize = true;
            this.lblFaltaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaMarca.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaMarca.Location = new System.Drawing.Point(432, 200);
            this.lblFaltaMarca.Name = "lblFaltaMarca";
            this.lblFaltaMarca.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaMarca.TabIndex = 19;
            this.lblFaltaMarca.Text = "*";
            // 
            // lblFaltaCategoria
            // 
            this.lblFaltaCategoria.AutoSize = true;
            this.lblFaltaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaCategoria.Location = new System.Drawing.Point(432, 252);
            this.lblFaltaCategoria.Name = "lblFaltaCategoria";
            this.lblFaltaCategoria.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaCategoria.TabIndex = 20;
            this.lblFaltaCategoria.Text = "*";
            // 
            // lblFaltaPrecio
            // 
            this.lblFaltaPrecio.AutoSize = true;
            this.lblFaltaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaPrecio.Location = new System.Drawing.Point(432, 365);
            this.lblFaltaPrecio.Name = "lblFaltaPrecio";
            this.lblFaltaPrecio.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaPrecio.TabIndex = 21;
            this.lblFaltaPrecio.Text = "*";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 492);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(193, 18);
            this.lblCamposObligatorios.TabIndex = 22;
            this.lblCamposObligatorios.Text = "*Faltan campos obligatorios";
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSoloNumeros.Location = new System.Drawing.Point(223, 390);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(249, 16);
            this.lblSoloNumeros.TabIndex = 23;
            this.lblSoloNumeros.Text = "Solo puede ingresar números (positivos)";
            this.lblSoloNumeros.Visible = false;
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 519);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.lblFaltaPrecio);
            this.Controls.Add(this.lblFaltaCategoria);
            this.Controls.Add(this.lblFaltaMarca);
            this.Controls.Add(this.lblFaltaDescripcion);
            this.Controls.Add(this.lblFaltaNombre);
            this.Controls.Add(this.lblFaltaCodigo);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Controls.Add(this.btnAgregarImagenes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTAgregarArticulo);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBCodigoArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBCodigoArticulo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Button BTAgregarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarImagenes;
        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblFaltaCodigo;
        private System.Windows.Forms.Label lblFaltaNombre;
        private System.Windows.Forms.Label lblFaltaDescripcion;
        private System.Windows.Forms.Label lblFaltaMarca;
        private System.Windows.Forms.Label lblFaltaCategoria;
        private System.Windows.Forms.Label lblFaltaPrecio;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblSoloNumeros;
    }
}