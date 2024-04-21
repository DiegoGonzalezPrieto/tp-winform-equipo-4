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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTModificarID = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BTModificarCodigo = new System.Windows.Forms.Button();
            this.BTModificarNombre = new System.Windows.Forms.Button();
            this.BTModificarDescripcion = new System.Windows.Forms.Button();
            this.BTModificarMarca = new System.Windows.Forms.Button();
            this.BTModificarCategoria = new System.Windows.Forms.Button();
            this.BTGuardarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDescripcion.Location = new System.Drawing.Point(302, 272);
            this.TBDescripcion.MaxLength = 100;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.Size = new System.Drawing.Size(357, 27);
            this.TBDescripcion.TabIndex = 18;
            this.TBDescripcion.TabStop = false;
            this.TBDescripcion.Text = "Descripcion correspondiente";
            // 
            // TBNombre
            // 
            this.TBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNombre.Location = new System.Drawing.Point(302, 193);
            this.TBNombre.MaxLength = 50;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.ReadOnly = true;
            this.TBNombre.Size = new System.Drawing.Size(357, 27);
            this.TBNombre.TabIndex = 17;
            this.TBNombre.TabStop = false;
            this.TBNombre.Text = "Nombre Correspondiente";
            // 
            // TBCodigoArticulo
            // 
            this.TBCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoArticulo.Location = new System.Drawing.Point(302, 114);
            this.TBCodigoArticulo.MaxLength = 3;
            this.TBCodigoArticulo.Name = "TBCodigoArticulo";
            this.TBCodigoArticulo.ReadOnly = true;
            this.TBCodigoArticulo.Size = new System.Drawing.Size(357, 27);
            this.TBCodigoArticulo.TabIndex = 16;
            this.TBCodigoArticulo.TabStop = false;
            this.TBCodigoArticulo.Text = "CA Correspondiente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Código de artículo:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(302, 31);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 27);
            this.textBox1.TabIndex = 22;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "ID Correspondiente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID:";
            // 
            // BTModificarID
            // 
            this.BTModificarID.Enabled = false;
            this.BTModificarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarID.Location = new System.Drawing.Point(674, 29);
            this.BTModificarID.Name = "BTModificarID";
            this.BTModificarID.Size = new System.Drawing.Size(114, 31);
            this.BTModificarID.TabIndex = 23;
            this.BTModificarID.Text = "Modificar";
            this.BTModificarID.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(302, 430);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(357, 27);
            this.textBox2.TabIndex = 25;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Categoria Correspondiente";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(302, 351);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(357, 27);
            this.textBox3.TabIndex = 24;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Marca Correspondiente";
            // 
            // BTModificarCodigo
            // 
            this.BTModificarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarCodigo.Location = new System.Drawing.Point(674, 112);
            this.BTModificarCodigo.Name = "BTModificarCodigo";
            this.BTModificarCodigo.Size = new System.Drawing.Size(114, 31);
            this.BTModificarCodigo.TabIndex = 26;
            this.BTModificarCodigo.Text = "Modificar";
            this.BTModificarCodigo.UseVisualStyleBackColor = true;
            this.BTModificarCodigo.Click += new System.EventHandler(this.BTModificarCodigo_Click);
            // 
            // BTModificarNombre
            // 
            this.BTModificarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarNombre.Location = new System.Drawing.Point(674, 191);
            this.BTModificarNombre.Name = "BTModificarNombre";
            this.BTModificarNombre.Size = new System.Drawing.Size(114, 31);
            this.BTModificarNombre.TabIndex = 27;
            this.BTModificarNombre.Text = "Modificar";
            this.BTModificarNombre.UseVisualStyleBackColor = true;
            // 
            // BTModificarDescripcion
            // 
            this.BTModificarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarDescripcion.Location = new System.Drawing.Point(674, 270);
            this.BTModificarDescripcion.Name = "BTModificarDescripcion";
            this.BTModificarDescripcion.Size = new System.Drawing.Size(114, 31);
            this.BTModificarDescripcion.TabIndex = 28;
            this.BTModificarDescripcion.Text = "Modificar";
            this.BTModificarDescripcion.UseVisualStyleBackColor = true;
            // 
            // BTModificarMarca
            // 
            this.BTModificarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarMarca.Location = new System.Drawing.Point(674, 349);
            this.BTModificarMarca.Name = "BTModificarMarca";
            this.BTModificarMarca.Size = new System.Drawing.Size(114, 31);
            this.BTModificarMarca.TabIndex = 29;
            this.BTModificarMarca.Text = "Modificar";
            this.BTModificarMarca.UseVisualStyleBackColor = true;
            // 
            // BTModificarCategoria
            // 
            this.BTModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarCategoria.Location = new System.Drawing.Point(674, 428);
            this.BTModificarCategoria.Name = "BTModificarCategoria";
            this.BTModificarCategoria.Size = new System.Drawing.Size(114, 31);
            this.BTModificarCategoria.TabIndex = 30;
            this.BTModificarCategoria.Text = "Modificar";
            this.BTModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // BTGuardarArticulo
            // 
            this.BTGuardarArticulo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTGuardarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGuardarArticulo.Location = new System.Drawing.Point(289, 493);
            this.BTGuardarArticulo.Name = "BTGuardarArticulo";
            this.BTGuardarArticulo.Size = new System.Drawing.Size(304, 48);
            this.BTGuardarArticulo.TabIndex = 31;
            this.BTGuardarArticulo.Text = "Guardar Articulo";
            this.BTGuardarArticulo.UseVisualStyleBackColor = true;
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.BTGuardarArticulo);
            this.Controls.Add(this.BTModificarCategoria);
            this.Controls.Add(this.BTModificarMarca);
            this.Controls.Add(this.BTModificarDescripcion);
            this.Controls.Add(this.BTModificarNombre);
            this.Controls.Add(this.BTModificarCodigo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BTModificarID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTModificarID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BTModificarCodigo;
        private System.Windows.Forms.Button BTModificarNombre;
        private System.Windows.Forms.Button BTModificarDescripcion;
        private System.Windows.Forms.Button BTModificarMarca;
        private System.Windows.Forms.Button BTModificarCategoria;
        private System.Windows.Forms.Button BTGuardarArticulo;
    }
}