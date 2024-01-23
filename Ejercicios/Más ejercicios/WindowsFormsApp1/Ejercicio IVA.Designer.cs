namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labcant = new System.Windows.Forms.Label();
            this.labprecio = new System.Windows.Forms.Label();
            this.textBoxcant = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labSubtotal = new System.Windows.Forms.Label();
            this.labIva = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labcant
            // 
            this.labcant.AutoSize = true;
            this.labcant.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcant.Location = new System.Drawing.Point(43, 45);
            this.labcant.Name = "labcant";
            this.labcant.Size = new System.Drawing.Size(91, 26);
            this.labcant.TabIndex = 0;
            this.labcant.Text = "Cantidad";
            // 
            // labprecio
            // 
            this.labprecio.AutoSize = true;
            this.labprecio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labprecio.Location = new System.Drawing.Point(227, 45);
            this.labprecio.Name = "labprecio";
            this.labprecio.Size = new System.Drawing.Size(66, 26);
            this.labprecio.TabIndex = 1;
            this.labprecio.Text = "Precio";
            // 
            // textBoxcant
            // 
            this.textBoxcant.Location = new System.Drawing.Point(48, 98);
            this.textBoxcant.Name = "textBoxcant";
            this.textBoxcant.Size = new System.Drawing.Size(100, 22);
            this.textBoxcant.TabIndex = 2;
            this.textBoxcant.TextChanged += new System.EventHandler(this.textBoxcant_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(232, 98);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // labSubtotal
            // 
            this.labSubtotal.AutoSize = true;
            this.labSubtotal.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSubtotal.Location = new System.Drawing.Point(381, 101);
            this.labSubtotal.Name = "labSubtotal";
            this.labSubtotal.Size = new System.Drawing.Size(87, 26);
            this.labSubtotal.TabIndex = 4;
            this.labSubtotal.Text = "Subtotal";
            // 
            // labIva
            // 
            this.labIva.AutoSize = true;
            this.labIva.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIva.Location = new System.Drawing.Point(381, 166);
            this.labIva.Name = "labIva";
            this.labIva.Size = new System.Drawing.Size(80, 26);
            this.labIva.TabIndex = 5;
            this.labIva.Text = "Iva 21%";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotal.Location = new System.Drawing.Point(381, 239);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(56, 26);
            this.labTotal.TabIndex = 6;
            this.labTotal.Text = "Total";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Enabled = false;
            this.textBoxSubtotal.Location = new System.Drawing.Point(488, 103);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxSubtotal.TabIndex = 7;
            // 
            // textBoxIva
            // 
            this.textBoxIva.Enabled = false;
            this.textBoxIva.Location = new System.Drawing.Point(488, 168);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.Size = new System.Drawing.Size(100, 22);
            this.textBoxIva.TabIndex = 8;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(488, 243);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotal.TabIndex = 9;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(12, 194);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(105, 80);
            this.btCalcular.TabIndex = 11;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpiar.Location = new System.Drawing.Point(138, 194);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(105, 80);
            this.btLimpiar.TabIndex = 12;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(270, 194);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(105, 80);
            this.btCerrar.TabIndex = 13;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 291);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxIva);
            this.Controls.Add(this.textBoxSubtotal);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labIva);
            this.Controls.Add(this.labSubtotal);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxcant);
            this.Controls.Add(this.labprecio);
            this.Controls.Add(this.labcant);
            this.Name = "Form1";
            this.Text = "Iva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labcant;
        private System.Windows.Forms.Label labprecio;
        private System.Windows.Forms.TextBox textBoxcant;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labSubtotal;
        private System.Windows.Forms.Label labIva;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btCerrar;
    }
}

