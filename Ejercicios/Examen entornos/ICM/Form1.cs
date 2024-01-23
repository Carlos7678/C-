using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICM
{
    public partial class Form1 : Form
    {
        double altura;
        double imc;
        double peso;
        public Form1()
        {
            InitializeComponent();
            comboBoxIdioma.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CambiarIdioma();
        }
        public void CambiarIdioma()
        {
            if (comboBoxIdioma.SelectedIndex == 0)
            {

                labelAltura.Text = "Altura:";
                labelPeso.Text = "Peso:";
                labelImc.Text = "Tu IMC:";
                buttonCalcular.Text = "Calcular";
                btBorrar.Text = "Borrar";
            }
            else
            {
                labelAltura.Text = "Height:";
                labelPeso.Text = "Weight:";
                labelImc.Text = "Your IMC:";
                buttonCalcular.Text = "Calculate";
                btBorrar.Text = "Erase";
            }

        }
        public void Borrar()
        {
            textBoxAltura.Clear();
            textBoxPeso.Clear();
            textBoxIMC.Clear();
            labelTipo.Text = "Tipo";

        }
        public void ComprobarBlancoAltura()
        {
            if (textBoxAltura.TextLength == 0)
            {
                MessageBox.Show("Introduce una altura (No debes dejar el campo en blanco)");
            }

        }

        public void ComprobarBlancoPeso()
        {
            if (textBoxPeso.TextLength == 0)
            {
                MessageBox.Show("Introduce un peso (No debes dejar el campo en blanco)");
            }

        }

        public void NegativoAPositivo()
        {
            if (altura <0)
            {
                altura=Math.Abs(altura);
                textBoxAltura.Text = altura.ToString();
            }
            if (peso < 0)
            {
                peso=Math.Abs(peso);
                textBoxPeso.Text = peso.ToString();
            }

        }
        public void PasarCm()
        {
            altura = altura / 100;
        }

        public void IMC()
        {
            if (imc < 16.00)
            {
                labelTipo.Text = "Tipo: Infrapeso:Delgadez severa";
            }
            else
            {
                if (imc < 17.00)
                {
                    labelTipo.Text = "Tipo: Infrapeso:Delgadez moderada";
                }
                else
                    if (imc < 18.50)
                {
                    labelTipo.Text = "Tipo: Infrapeso:Delgadez aceptable";
                }
                else
                {
                    if (imc < 25.00)
                    {
                        labelTipo.Text = "Tipo: Peso normal";
                    }
                    else
                    {
                        if (imc < 30.00)
                        {
                            labelTipo.Text = "Tipo: Sobrepeso";
                        }
                        else
                        {
                            if (imc < 35.00)
                            {
                                labelTipo.Text = "Tipo: Obeso: Tipo I";
                            }
                            else
                            {
                                if (imc < 40.01)
                                {
                                    labelTipo.Text = "Tipo: Obeso: Tipo II";
                                }
                                else
                                {
                                    if (imc > 40.00)
                                    {
                                        labelTipo.Text = "Tipo:Obeso:Tipo III";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            try
            {

                altura = Double.Parse(textBoxAltura.Text);
               
                peso = Double.Parse(textBoxPeso.Text);
                NegativoAPositivo();
                PasarCm();
                imc = peso / (altura*altura);
                textBoxIMC.Text = imc.ToString();
                IMC();
            }
            catch (FormatException ex)
            {
                ComprobarBlancoAltura();
                ComprobarBlancoPeso();
                MessageBox.Show("Introduce un numero valido");

            }
        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
