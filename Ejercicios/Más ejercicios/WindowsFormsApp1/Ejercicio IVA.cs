using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxcant.Clear();
            textBoxPrecio.Clear();
            textBoxSubtotal.Clear();
            textBoxIva.Clear();
            textBoxTotal.Clear();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int num1,absnum1;
                double num2, mult,iva,total,absnum2;
                num1 = int.Parse(textBoxcant.Text);
                num2 = Double.Parse(textBoxPrecio.Text);
                absnum1 = Math.Abs(num1);
                absnum2 = Math.Abs(num2);
                mult = absnum1 * absnum2;
                iva = mult * 21 / 100;
                total = mult + iva;
                textBoxcant.Text = absnum1.ToString();
                textBoxPrecio.Text = absnum2.ToString();
                textBoxSubtotal.Text = mult.ToString();
                textBoxIva.Text=iva.ToString();
                textBoxTotal.Text = total.ToString();
            }

            
            catch (FormatException error)
            {
                MessageBox.Show($"ERROR EN FORMATO INTRODUCIDO:{error}");
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxcant_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
    }

