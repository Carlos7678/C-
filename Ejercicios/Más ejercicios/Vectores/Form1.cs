using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    using Microsoft.VisualBasic;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int[] vector = new int[10];
                int[] par = new int[0];
                int[] impar = new int[0];
                string coma = " , ";
                int j = 0, k = 0;
                for (int i = 0; i < 10; i++)
                {
                    vector[i] = int.Parse(Interaction.InputBox("Introduce un número", "Introducir números",
                         String.Empty, -1, -1));

                    if (vector[i] % 2 == 0)
                    {
                        Array.Resize(ref par, par.Length + 1);
                        par[j] = vector[i];
                        j++;
                    }
                    else
                    {
                        Array.Resize(ref impar, impar.Length + 1);
                        impar[k] = vector[i];
                        k++;
                    }
                }
                textBoxOriginal.Text = String.Join(coma, vector);
                Array.Sort(vector);
                textBoxOrdenado.Text = String.Join(coma, vector);
                Array.Sort(par);
                Array.Sort(impar);
                textBoxPar.Text = String.Join(coma, par);
                textBoxImpar.Text = String.Join(coma, impar);
            }
            catch (FormatException error)
            {
                MessageBox.Show($"ERROR EN FORMATO INTRODUCIDO:{error}");
            }
        }
    }
}
