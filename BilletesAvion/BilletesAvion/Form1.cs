using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilletesAvion
{
    public partial class Form1 : Form
    {
        int precio = 0;
        public Form1()
        {
            InitializeComponent();
            añadirOrigen();
            añadirGastos();
        }

     public void añadirOrigen()
        {
             comboBoxOrigen.Items.Add("MADRID");
            comboBoxOrigen.Items.Add("BARCELONA");
            comboBoxOrigen.Items.Add("VALENCIA");
        }
        public void añadirGastos()
        {
            GastosAdicionales.Items.Add("Facturar maleta 15€");
            GastosAdicionales.Items.Add("Seguro cancelacion 45€");
            GastosAdicionales.Items.Add("Comida Gourmet 22€");
            GastosAdicionales.Items.Add("Paso preferente 2€");
        }
        public void LimpiarDestino()
        {
            comboBoxDestino.Items.Clear();
        }
        public void MostrarPrecio()
        {
           cPrecioTotal.Text=precio.ToString()+"€";
        }
        private void cPrecioTotal_TextChanged(object sender, EventArgs e)
        {

        }
        public void ComprobarVuelos()
        {
            if (comboBoxOrigen.SelectedIndex <0 && comboBoxDestino.SelectedIndex <0)
            {
                textBoxError1.Clear();
                textBoxError1.Text = "Introduce la ciudad de origen y destino";
            }
            else
            {
                if (comboBoxOrigen.SelectedIndex <0)
                {
                    textBoxError1.Clear();
                    textBoxError1.Text = "Introduce la ciudad de origen";
                }
                else
                {
                    if (comboBoxDestino.SelectedIndex <0)
                    {
                        textBoxError1.Clear();
                        textBoxError1.Text = "Introduce la ciudad de destino";
                    }
                    else { textBoxError1.Clear(); }
                }

            }
        }
        public void CalcularPrecio()
        {
            if (comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0 ||
               comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 1 ||
               comboBoxOrigen.SelectedIndex == 2 && comboBoxDestino.SelectedIndex == 1)
            {
                precio = precio + 50;
                
            }
            if (comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 1)
            {
                precio = precio + 60;
            }
            if (comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 0)
            {
                precio = precio + 45;
            }
            if (comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 2)
            {
                precio = precio + 70;
            }
            if (comboBoxOrigen.SelectedIndex == 2 && comboBoxDestino.SelectedIndex == 0)
            {
                precio = precio + 40;
            }
        }
        public void validarFechas()
        {
            

            if (dateTimePickerDestino.Value < dateTimePickerOrigen.Value)
            {
                textBox1.Text = " Selecciona una fecha valida";
            }
            else
            {
                textBox1.Clear();
            }
        }
        
        private void comboBoxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int precio=0;
            comboBoxOrigen.Text = Convert.ToString(comboBoxOrigen.SelectedItem);
            //INDICES ORIGEN
            //    0=MADRID
            //    1=BARCELONA
            //    2=VALENCIA
            if (comboBoxOrigen.SelectedIndex == 0)
            {
                LimpiarDestino();
                comboBoxDestino.Items.Add("PRAGA");
                comboBoxDestino.Items.Add("BERLÍN");
            }
            if (comboBoxOrigen.SelectedIndex == 1)
            {
                LimpiarDestino();
                comboBoxDestino.Items.Add("PRAGA");
                comboBoxDestino.Items.Add("BERLÍN");
                comboBoxDestino.Items.Add("OSLO");
            }
            if (comboBoxOrigen.SelectedIndex == 2)
            {
                LimpiarDestino();
                comboBoxDestino.Items.Add("LISBOA");
                comboBoxDestino.Items.Add("PRAGA");
            }
            //INDICES DESTINO SI ORIGEN ES MADRID
            //    0=PRAGA
            //    1=BERLÍN
            //INDICES DESTINO SI ORIGEN ES BARCELONA
            //    0=PRAGA
            //    1=BERLÍN
            //    2=OSLO
            //INDICES DESTINO SI ORIGEN ES VALENCIA
            //    0=LISBOA
            //    1=PRAGA

            if (comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 0||
                comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 1||
                comboBoxOrigen.SelectedIndex == 2 && comboBoxDestino.SelectedIndex == 1)
            {
                precio=precio+ 50;
            }
           if(comboBoxOrigen.SelectedIndex == 0 && comboBoxDestino.SelectedIndex == 1)
            {
                precio = precio + 60;
            }
            if (comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 0)
            {
                precio = precio + 45;
            }
            if (comboBoxOrigen.SelectedIndex == 1 && comboBoxDestino.SelectedIndex == 2)
            {
                precio = precio + 70;
            }
            if (comboBoxOrigen.SelectedIndex == 2 && comboBoxDestino.SelectedIndex == 0)
            {
                precio = precio + 40;
            }
        }

        private void GastosAdicionales_SelectedIndexChanged(object sender, EventArgs e)
        {
           

          
                //if (i == 0)
                //{
                //    precio = precio + 15;
                //}
                //if (i == 1)
                //{
                //    precio = precio + 45;
                //}
                //if (i == 2)
                //{
                //    precio = precio + 22;
                //}
                //if (i == 3)
                //{
                //    precio = precio + 2;
                //}
            
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            precio = 0;
            ComprobarVuelos();
            validarFechas();
            CalcularPrecio();
            MostrarPrecio();
        }
    }
}
