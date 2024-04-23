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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoría:";
            // 
            // TBCodigoArticulo
            // 
            this.TBCodigoArticulo.AccessibleName = "";
            this.TBCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoArticulo.Location = new System.Drawing.Point(179, 50);
            this.TBCodigoArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBCodigoArticulo.MaxLength = 4;
            this.TBCodigoArticulo.Name = "TBCodigoArticulo";
            this.TBCodigoArticulo.Size = new System.Drawing.Size(151, 23);
            this.TBCodigoArticulo.TabIndex = 0;
            this.TBCodigoArticulo.TextChanged += new System.EventHandler(this.TBCodigoArticulo_TextChanged);
            // 
            // TBNombre
            // 
            this.TBNombre.AccessibleName = "";
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(179, 95);
            this.TBNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBNombre.MaxLength = 50;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(151, 23);
            this.TBNombre.TabIndex = 1;
            this.TBNombre.Tag = "";
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(179, 140);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBDescripcion.MaxLength = 100;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(151, 23);
            this.TBDescripcion.TabIndex = 2;
            this.TBDescripcion.TextChanged += new System.EventHandler(this.TBDescripcion_TextChanged);
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
            this.CBMarca.Location = new System.Drawing.Point(179, 184);
            this.CBMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBMarca.MaxLength = 2;
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(151, 25);
            this.CBMarca.TabIndex = 3;
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
            this.CBCategoria.Location = new System.Drawing.Point(179, 229);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBCategoria.MaxLength = 2;
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(151, 25);
            this.CBCategoria.TabIndex = 4;
            this.CBCategoria.SelectedIndexChanged += new System.EventHandler(this.CBCategoria_SelectedIndexChanged);
            // 
            // BTAgregarArticulo
            // 
            this.BTAgregarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAgregarArticulo.Location = new System.Drawing.Point(110, 382);
            this.BTAgregarArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTAgregarArticulo.Name = "BTAgregarArticulo";
            this.BTAgregarArticulo.Size = new System.Drawing.Size(175, 29);
            this.BTAgregarArticulo.TabIndex = 6;
            this.BTAgregarArticulo.Text = "Agregar Artículo";
            this.BTAgregarArticulo.UseVisualStyleBackColor = true;
            this.BTAgregarArticulo.Click += new System.EventHandler(this.BTAgregarArticulo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Precio:";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPrecio.Location = new System.Drawing.Point(179, 318);
            this.TBPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPrecio.MaxLength = 8;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(151, 23);
            this.TBPrecio.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(101, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Imagen:";
            // 
            // btnAgregarImagenes
            // 
            this.btnAgregarImagenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagenes.Location = new System.Drawing.Point(179, 272);
            this.btnAgregarImagenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarImagenes.Name = "btnAgregarImagenes";
            this.btnAgregarImagenes.Size = new System.Drawing.Size(150, 28);
            this.btnAgregarImagenes.TabIndex = 14;
            this.btnAgregarImagenes.Text = "Agregar";
            this.btnAgregarImagenes.UseVisualStyleBackColor = true;
            this.btnAgregarImagenes.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 474);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}