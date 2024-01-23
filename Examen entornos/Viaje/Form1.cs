using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // dt.Format = DateTimePickerFormat.Long;
        }

        private void dt_DateChanged(object sender, DateRangeEventArgs e)
        {
           // dt. = DateTimePickerFormat.Long;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            bool seguir = true;          
                double precio = 0;

            if (cbOrigen.Text.Equals("MADRID") && cbDestino.Text.Equals("PRAGA"))
            {
                precio += 50;
                
            }

            if (cbOrigen.Text.Equals("MADRID") && cbDestino.Text.Equals("BERLÍN"))
            {
                precio += 60;

            }

            if (cbOrigen.Text.Equals("BARCELONA") && cbDestino.Text.Equals("PRAGA"))
            {
                precio += 45;

            }

            if (cbOrigen.Text.Equals("BARCELONA") && cbDestino.Text.Equals("BERLÍN"))
            {
                precio += 50;

            }

            if (cbOrigen.Text.Equals("BARCELONA") && cbDestino.Text.Equals("OSLO"))
            {
                precio += 70;

            }

            if (cbOrigen.Text.Equals("VALENCIA") && cbDestino.Text.Equals("LISBOA"))
            {
                precio += 40;

            }

            if (cbOrigen.Text.Equals("VALENCIA") && cbDestino.Text.Equals("PRAGA"))
            {
                precio += 50;
            }
            String ListFac = "";
            if (cbFacturam.Checked)
            {
                precio += 15;
                ListFac = " (F)";
            }

            String diaF = fechaOrigen.Value.DayOfWeek + "";

            if (diaF.Equals("Monday"))
            {
                precio = precio - precio * 0.10 ;
                
            }

            if (cbOrigen.SelectedItem != null && cbDestino.SelectedItem != null && fechaDestino.Value.Date > fechaOrigen.Value.Date)
            {
                Hvuelos.Items.Add("ORIGEN:" + cbOrigen.Text + ".FECHA:" + fechaOrigen.Value.ToShortDateString() +
                "DESTINO:" + cbDestino.Text + " FECHA:" + fechaDestino.Value.ToShortDateString() + "PRECIO:" + precio +"€" + ListFac);
            }
            else {
                MessageBox.Show("Tiene que seleccionar origen y destino");
            }

            //que el dia sea posterior al de la creacion
            if (fechaDestino.Value.Date< fechaOrigen.Value.Date)
            {
                MessageBox.Show("la fecha origen tiene que ser mayor que la de destino");
            }
            

        }

        

    private void cbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] barcelona = new string[] {"PRAGA" ,"BERLÍN","OSLO"};
            String[] valencia = new string[] { "LISBOA", "PRAGA" };
            String[] madrid = new string[] { "PRAGA", "BERLÍN" };
            string comprobar = cbOrigen.Text;
            if (comprobar.Equals("BARCELONA"))
            {
                cbDestino.Items.Clear();
                cbDestino.Items.AddRange(barcelona);
          //      cbDestino.Items.Insert( 0,"Copenhagen");
            }
          //   comprobar = cbOrigen.Text;
            if (comprobar.Equals("VALENCIA"))
            {
                cbDestino.Items.Clear();
                cbDestino.Items.AddRange(valencia);
            }

            if (comprobar.Equals("MADRID"))
            {
                cbDestino.Items.Clear();
                cbDestino.Items.AddRange(madrid);
            }


        }
    }
}
