
namespace Viaje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.fechaOrigen = new System.Windows.Forms.DateTimePicker();
            this.fechaDestino = new System.Windows.Forms.DateTimePicker();
            this.cbFacturam = new System.Windows.Forms.CheckBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hvuelos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Items.AddRange(new object[] {
            "MADRID",
            "BARCELONA",
            "VALENCIA"});
            this.cbOrigen.Location = new System.Drawing.Point(134, 56);
            this.cbOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(129, 21);
            this.cbOrigen.TabIndex = 2;
            this.cbOrigen.UseWaitCursor = true;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(134, 93);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(129, 21);
            this.cbDestino.TabIndex = 3;
            // 
            // fechaOrigen
            // 
            this.fechaOrigen.Location = new System.Drawing.Point(316, 58);
            this.fechaOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaOrigen.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.fechaOrigen.MinDate = new System.DateTime(2022, 5, 27, 0, 0, 0, 0);
            this.fechaOrigen.Name = "fechaOrigen";
            this.fechaOrigen.Size = new System.Drawing.Size(205, 20);
            this.fechaOrigen.TabIndex = 5;
            // 
            // fechaDestino
            // 
            this.fechaDestino.Location = new System.Drawing.Point(316, 93);
            this.fechaDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaDestino.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.fechaDestino.MinDate = new System.DateTime(2022, 5, 27, 0, 0, 0, 0);
            this.fechaDestino.Name = "fechaDestino";
            this.fechaDestino.Size = new System.Drawing.Size(205, 20);
            this.fechaDestino.TabIndex = 6;
            this.fechaDestino.Value = new System.DateTime(2022, 5, 27, 12, 25, 36, 0);
            // 
            // cbFacturam
            // 
            this.cbFacturam.AutoSize = true;
            this.cbFacturam.Location = new System.Drawing.Point(34, 184);
            this.cbFacturam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFacturam.Name = "cbFacturam";
            this.cbFacturam.Size = new System.Drawing.Size(117, 17);
            this.cbFacturam.TabIndex = 7;
            this.cbFacturam.Text = "Factura maleta 15€";
            this.cbFacturam.UseVisualStyleBackColor = true;
            // 
            // bCalcular
            // 
            this.bCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.Location = new System.Drawing.Point(34, 274);
            this.bCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(184, 79);
            this.bCalcular.TabIndex = 12;
            this.bCalcular.Text = "AÑADIR VUELO";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "GASTOS ADICINALES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "HISTORIAL VUELOS";
            // 
            // Hvuelos
            // 
            this.Hvuelos.FormattingEnabled = true;
            this.Hvuelos.Location = new System.Drawing.Point(271, 207);
            this.Hvuelos.Name = "Hvuelos";
            this.Hvuelos.Size = new System.Drawing.Size(595, 160);
            this.Hvuelos.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 417);
            this.Controls.Add(this.Hvuelos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.cbFacturam);
            this.Controls.Add(this.fechaDestino);
            this.Controls.Add(this.fechaOrigen);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.DateTimePicker fechaOrigen;
        private System.Windows.Forms.DateTimePicker fechaDestino;
        private System.Windows.Forms.CheckBox cbFacturam;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Hvuelos;
    }
}

