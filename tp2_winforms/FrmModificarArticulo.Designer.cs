namespace Inventario
{
    partial class ModificarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarArticulo));
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodigoArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTGuardarArticulo = new System.Windows.Forms.Button();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnModificarImagenes = new System.Windows.Forms.Button();
            this.lblAgregarArticulo = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.lblFaltaPrecio = new System.Windows.Forms.Label();
            this.lblFaltaDescripcion = new System.Windows.Forms.Label();
            this.lblFaltaNombre = new System.Windows.Forms.Label();
            this.lblFaltaCodigo = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.lblCodigoInvalido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(226, 141);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBDescripcion.MaxLength = 100;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(200, 27);
            this.TBDescripcion.TabIndex = 18;
            this.TBDescripcion.Leave += new System.EventHandler(this.TBDescripcion_Leave);
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(226, 87);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBNombre.MaxLength = 50;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(200, 27);
            this.TBNombre.TabIndex = 17;
            this.TBNombre.Leave += new System.EventHandler(this.TBNombre_Leave);
            // 
            // TBCodigoArticulo
            // 
            this.TBCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoArticulo.Location = new System.Drawing.Point(226, 31);
            this.TBCodigoArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBCodigoArticulo.MaxLength = 3;
            this.TBCodigoArticulo.Name = "TBCodigoArticulo";
            this.TBCodigoArticulo.Size = new System.Drawing.Size(200, 27);
            this.TBCodigoArticulo.TabIndex = 16;
            this.TBCodigoArticulo.Leave += new System.EventHandler(this.TBCodigoArticulo_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código:";
            // 
            // BTGuardarArticulo
            // 
            this.BTGuardarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTGuardarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardarArticulo.Location = new System.Drawing.Point(128, 428);
            this.BTGuardarArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTGuardarArticulo.Name = "BTGuardarArticulo";
            this.BTGuardarArticulo.Size = new System.Drawing.Size(233, 36);
            this.BTGuardarArticulo.TabIndex = 31;
            this.BTGuardarArticulo.Text = "Guardar Articulo";
            this.BTGuardarArticulo.UseVisualStyleBackColor = true;
            this.BTGuardarArticulo.Click += new System.EventHandler(this.BTGuardarArticulo_Click);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio.Location = new System.Drawing.Point(226, 361);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBPrecio.MaxLength = 100;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(200, 27);
            this.TBPrecio.TabIndex = 33;
            this.TBPrecio.Leave += new System.EventHandler(this.TBPrecio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Imágenes:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(226, 255);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(200, 24);
            this.cbCategoria.TabIndex = 36;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Location = new System.Drawing.Point(226, 199);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(200, 24);
            this.cbMarca.TabIndex = 37;
            // 
            // btnModificarImagenes
            // 
            this.btnModificarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarImagenes.Location = new System.Drawing.Point(226, 304);
            this.btnModificarImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarImagenes.Name = "btnModificarImagenes";
            this.btnModificarImagenes.Size = new System.Drawing.Size(200, 34);
            this.btnModificarImagenes.TabIndex = 38;
            this.btnModificarImagenes.Text = "Modificar";
            this.btnModificarImagenes.UseVisualStyleBackColor = true;
            this.btnModificarImagenes.Click += new System.EventHandler(this.btnModificarImagenes_Click);
            // 
            // lblAgregarArticulo
            // 
            this.lblAgregarArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("lblAgregarArticulo.Image")));
            this.lblAgregarArticulo.Location = new System.Drawing.Point(365, 421);
            this.lblAgregarArticulo.Name = "lblAgregarArticulo";
            this.lblAgregarArticulo.Size = new System.Drawing.Size(50, 50);
            this.lblAgregarArticulo.TabIndex = 39;
            this.lblAgregarArticulo.Text = "  ";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.Red;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(12, 492);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(193, 18);
            this.lblCamposObligatorios.TabIndex = 40;
            this.lblCamposObligatorios.Text = "*Faltan campos obligatorios";
            this.lblCamposObligatorios.Visible = false;
            // 
            // lblFaltaPrecio
            // 
            this.lblFaltaPrecio.AutoSize = true;
            this.lblFaltaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaPrecio.Location = new System.Drawing.Point(432, 364);
            this.lblFaltaPrecio.Name = "lblFaltaPrecio";
            this.lblFaltaPrecio.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaPrecio.TabIndex = 46;
            this.lblFaltaPrecio.Text = "*";
            this.lblFaltaPrecio.Visible = false;
            // 
            // lblFaltaDescripcion
            // 
            this.lblFaltaDescripcion.AutoSize = true;
            this.lblFaltaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaDescripcion.Location = new System.Drawing.Point(432, 144);
            this.lblFaltaDescripcion.Name = "lblFaltaDescripcion";
            this.lblFaltaDescripcion.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaDescripcion.TabIndex = 43;
            this.lblFaltaDescripcion.Text = "*";
            this.lblFaltaDescripcion.Visible = false;
            // 
            // lblFaltaNombre
            // 
            this.lblFaltaNombre.AutoSize = true;
            this.lblFaltaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaNombre.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaNombre.Location = new System.Drawing.Point(432, 90);
            this.lblFaltaNombre.Name = "lblFaltaNombre";
            this.lblFaltaNombre.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaNombre.TabIndex = 42;
            this.lblFaltaNombre.Text = "*";
            this.lblFaltaNombre.Visible = false;
            // 
            // lblFaltaCodigo
            // 
            this.lblFaltaCodigo.AutoSize = true;
            this.lblFaltaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaCodigo.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaCodigo.Location = new System.Drawing.Point(432, 34);
            this.lblFaltaCodigo.Name = "lblFaltaCodigo";
            this.lblFaltaCodigo.Size = new System.Drawing.Size(20, 25);
            this.lblFaltaCodigo.TabIndex = 41;
            this.lblFaltaCodigo.Text = "*";
            this.lblFaltaCodigo.Visible = false;
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSoloNumeros.Location = new System.Drawing.Point(223, 390);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(249, 16);
            this.lblSoloNumeros.TabIndex = 47;
            this.lblSoloNumeros.Text = "Solo puede ingresar números (positivos)";
            this.lblSoloNumeros.Visible = false;
            // 
            // lblCodigoInvalido
            // 
            this.lblCodigoInvalido.AutoSize = true;
            this.lblCodigoInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInvalido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoInvalido.Location = new System.Drawing.Point(223, 60);
            this.lblCodigoInvalido.Name = "lblCodigoInvalido";
            this.lblCodigoInvalido.Size = new System.Drawing.Size(244, 16);
            this.lblCodigoInvalido.TabIndex = 48;
            this.lblCodigoInvalido.Text = "Codigo invalido. Ej. Formato valido: A01";
            this.lblCodigoInvalido.Visible = false;
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 519);
            this.Controls.Add(this.lblCodigoInvalido);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.lblFaltaPrecio);
            this.Controls.Add(this.lblFaltaDescripcion);
            this.Controls.Add(this.lblFaltaNombre);
            this.Controls.Add(this.lblFaltaCodigo);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.lblAgregarArticulo);
            this.Controls.Add(this.btnModificarImagenes);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTGuardarArticulo);
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
            this.Name = "ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.Load += new System.EventHandler(this.ModificarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigoArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTGuardarArticulo;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnModificarImagenes;
        private System.Windows.Forms.Label lblAgregarArticulo;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblFaltaPrecio;
        private System.Windows.Forms.Label lblFaltaDescripcion;
        private System.Windows.Forms.Label lblFaltaNombre;
        private System.Windows.Forms.Label lblFaltaCodigo;
        private System.Windows.Forms.Label lblSoloNumeros;
        private System.Windows.Forms.Label lblCodigoInvalido;
    }
}