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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.tbNum3 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum1.Location = new System.Drawing.Point(152, 36);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(189, 31);
            this.labelNum1.TabIndex = 0;
            this.labelNum1.Text = "Introduce el nº1";
            this.labelNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum2.Location = new System.Drawing.Point(152, 93);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(193, 31);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "Introduce el nº2";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(223, 181);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(118, 31);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "Resultado";
            // 
            // tbNum3
            // 
            this.tbNum3.Location = new System.Drawing.Point(373, 102);
            this.tbNum3.Name = "tbNum3";
            this.tbNum3.Size = new System.Drawing.Size(155, 22);
            this.tbNum3.TabIndex = 5;
            // 
            // tbNum2
            // 
            this.tbNum2.Enabled = false;
            this.tbNum2.Location = new System.Drawing.Point(373, 181);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(155, 22);
            this.tbNum2.TabIndex = 6;
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(373, 36);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNum1.Size = new System.Drawing.Size(155, 22);
            this.tbNum1.TabIndex = 4;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(158, 215);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(177, 150);
            this.bt1.TabIndex = 7;
            this.bt1.Text = "SUMAR";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(373, 215);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(195, 150);
            this.bt2.TabIndex = 8;
            this.bt2.Text = "BORRAR";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click_1);
            // 
            // bt3
            // 
            this.bt3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt3.BackgroundImage")));
            this.bt3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt3.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(133, 389);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(144, 114);
            this.bt3.TabIndex = 9;
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 150);
            this.button1.TabIndex = 10;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum3);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox tbNum3;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button button1;
    }
}

