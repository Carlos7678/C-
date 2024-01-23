namespace BilletesAvion
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
            this.bCalcular = new System.Windows.Forms.Button();
            this.dateTimePickerOrigen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDestino = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrigen = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cPrecioTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GastosAdicionales = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxError1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCalcular
            // 
            this.bCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.Location = new System.Drawing.Point(233, 296);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(385, 61);
            this.bCalcular.TabIndex = 0;
            this.bCalcular.Text = "CALCULAR PRECIO";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // dateTimePickerOrigen
            // 
            this.dateTimePickerOrigen.Location = new System.Drawing.Point(408, 53);
            this.dateTimePickerOrigen.MaxDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerOrigen.MinDate = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            this.dateTimePickerOrigen.Name = "dateTimePickerOrigen";
            this.dateTimePickerOrigen.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerOrigen.TabIndex = 1;
            this.dateTimePickerOrigen.Value = new System.DateTime(2022, 5, 26, 13, 57, 40, 0);
            // 
            // dateTimePickerDestino
            // 
            this.dateTimePickerDestino.Location = new System.Drawing.Point(408, 109);
            this.dateTimePickerDestino.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDestino.MinDate = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            this.dateTimePickerDestino.Name = "dateTimePickerDestino";
            this.dateTimePickerDestino.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickerDestino.TabIndex = 2;
            // 
            // comboBoxOrigen
            // 
            this.comboBoxOrigen.FormattingEnabled = true;
            this.comboBoxOrigen.Location = new System.Drawing.Point(125, 59);
            this.comboBoxOrigen.Name = "comboBoxOrigen";
            this.comboBoxOrigen.Size = new System.Drawing.Size(170, 24);
            this.comboBoxOrigen.TabIndex = 3;
            this.comboBoxOrigen.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigen_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(125, 109);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(170, 24);
            this.comboBoxDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // cPrecioTotal
            // 
            this.cPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPrecioTotal.Location = new System.Drawing.Point(498, 215);
            this.cPrecioTotal.Multiline = true;
            this.cPrecioTotal.Name = "cPrecioTotal";
            this.cPrecioTotal.ReadOnly = true;
            this.cPrecioTotal.Size = new System.Drawing.Size(189, 50);
            this.cPrecioTotal.TabIndex = 7;
            this.cPrecioTotal.TextChanged += new System.EventHandler(this.cPrecioTotal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio total del billete";
            // 
            // GastosAdicionales
            // 
            this.GastosAdicionales.FormattingEnabled = true;
            this.GastosAdicionales.Location = new System.Drawing.Point(16, 224);
            this.GastosAdicionales.Name = "GastosAdicionales";
            this.GastosAdicionales.Size = new System.Drawing.Size(193, 123);
            this.GastosAdicionales.TabIndex = 9;
            this.GastosAdicionales.SelectedIndexChanged += new System.EventHandler(this.GastosAdicionales_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "GASTOS ADICIONALES";
            // 
            // textBoxError1
            // 
            this.textBoxError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxError1.ForeColor = System.Drawing.Color.Black;
            this.textBoxError1.Location = new System.Drawing.Point(12, 363);
            this.textBoxError1.Multiline = true;
            this.textBoxError1.Name = "textBoxError1";
            this.textBoxError1.ReadOnly = true;
            this.textBoxError1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxError1.Size = new System.Drawing.Size(776, 50);
            this.textBoxError1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(776, 50);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxError1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GastosAdicionales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cPrecioTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDestino);
            this.Controls.Add(this.comboBoxOrigen);
            this.Controls.Add(this.dateTimePickerDestino);
            this.Controls.Add(this.dateTimePickerOrigen);
            this.Controls.Add(this.bCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrigen;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestino;
        private System.Windows.Forms.ComboBox comboBoxOrigen;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cPrecioTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox GastosAdicionales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxError1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

