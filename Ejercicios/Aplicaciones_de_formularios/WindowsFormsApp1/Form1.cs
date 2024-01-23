using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, suma;
                num1 = int.Parse(tbNum1.Text);
                num2 = int.Parse(tbNum3.Text);
                suma = num1 + num2;
                tbNum2.Text = suma.ToString();
            }
            catch (ArithmeticException error)
            {
                MessageBox.Show($"ERROR ARITMETICO:{error}");
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR GENERICO:{error}");
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo=new StreamWriter(@"d:\ruta\archivo.txt");
            Archivo.WriteLine("OPERACIÓN:" + tbNum1.Text+"+"+tbNum3.Text+"="+tbNum2.Text);
            Archivo.Flush();
            Archivo.Close();

            System.Diagnostics.Process.Start(@"d:\ruta\archivo.txt");
        }

        private void bt2_Click_1(object sender, EventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
            tbNum3.Clear();
        }

        private void bt3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
