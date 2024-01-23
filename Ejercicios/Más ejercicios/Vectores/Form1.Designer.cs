namespace Vectores
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
            this.labelOriginal = new System.Windows.Forms.Label();
            this.labelOrdenado = new System.Windows.Forms.Label();
            this.labelPar = new System.Windows.Forms.Label();
            this.labelImpar = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.textBoxOrdenado = new System.Windows.Forms.TextBox();
            this.textBoxPar = new System.Windows.Forms.TextBox();
            this.textBoxImpar = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOriginal.Location = new System.Drawing.Point(39, 44);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(136, 25);
            this.labelOriginal.TabIndex = 0;
            this.labelOriginal.Text = "Vector original";
            // 
            // labelOrdenado
            // 
            this.labelOrdenado.AutoSize = true;
            this.labelOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdenado.Location = new System.Drawing.Point(39, 116);
            this.labelOrdenado.Name = "labelOrdenado";
            this.labelOrdenado.Size = new System.Drawing.Size(157, 25);
            this.labelOrdenado.TabIndex = 1;
            this.labelOrdenado.Text = "Vector ordenado";
            // 
            // labelPar
            // 
            this.labelPar.AutoSize = true;
            this.labelPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPar.Location = new System.Drawing.Point(39, 187);
            this.labelPar.Name = "labelPar";
            this.labelPar.Size = new System.Drawing.Size(145, 25);
            this.labelPar.TabIndex = 2;
            this.labelPar.Text = "Números pares";
            // 
            // labelImpar
            // 
            this.labelImpar.AutoSize = true;
            this.labelImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpar.Location = new System.Drawing.Point(39, 259);
            this.labelImpar.Name = "labelImpar";
            this.labelImpar.Size = new System.Drawing.Size(165, 25);
            this.labelImpar.TabIndex = 3;
            this.labelImpar.Text = "Números impares";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Enabled = false;
            this.textBoxOriginal.Location = new System.Drawing.Point(219, 44);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(315, 22);
            this.textBoxOriginal.TabIndex = 4;
            // 
            // textBoxOrdenado
            // 
            this.textBoxOrdenado.Enabled = false;
            this.textBoxOrdenado.Location = new System.Drawing.Point(219, 120);
            this.textBoxOrdenado.Name = "textBoxOrdenado";
            this.textBoxOrdenado.Size = new System.Drawing.Size(315, 22);
            this.textBoxOrdenado.TabIndex = 5;
            // 
            // textBoxPar
            // 
            this.textBoxPar.Enabled = false;
            this.textBoxPar.Location = new System.Drawing.Point(219, 191);
            this.textBoxPar.Name = "textBoxPar";
            this.textBoxPar.Size = new System.Drawing.Size(315, 22);
            this.textBoxPar.TabIndex = 6;
            // 
            // textBoxImpar
            // 
            this.textBoxImpar.Enabled = false;
            this.textBoxImpar.Location = new System.Drawing.Point(219, 263);
            this.textBoxImpar.Name = "textBoxImpar";
            this.textBoxImpar.Size = new System.Drawing.Size(315, 22);
            this.textBoxImpar.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(44, 347);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(152, 42);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular valores";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(275, 347);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(152, 42);
            this.buttonCerrar.TabIndex = 9;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxImpar);
            this.Controls.Add(this.textBoxPar);
            this.Controls.Add(this.textBoxOrdenado);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.labelImpar);
            this.Controls.Add(this.labelPar);
            this.Controls.Add(this.labelOrdenado);
            this.Controls.Add(this.labelOriginal);
            this.Name = "Form1";
            this.Text = "Vectores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.Label labelOrdenado;
        private System.Windows.Forms.Label labelPar;
        private System.Windows.Forms.Label labelImpar;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.TextBox textBoxOrdenado;
        private System.Windows.Forms.TextBox textBoxPar;
        private System.Windows.Forms.TextBox textBoxImpar;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonCerrar;
    }
}

