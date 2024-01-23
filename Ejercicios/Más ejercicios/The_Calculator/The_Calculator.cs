using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace The_Calculator
{
    public partial class The_Calculator : Form
    {
        public The_Calculator()
        {
            InitializeComponent();
            apagar();
        }
        private Boolean esComa;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Boton copiar
        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxResultado.Text);
        }
        //Boton reiniciar
        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            OperacionAnterior = Operacion.Nada;
            textBoxResultado.Clear();
            esComa = false;
            Agrandar();
            encender();
        }
        //Boton limpiar
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text.Length > 0)
            {
                Agrandar();
                double d;
                if (!double.TryParse(textBoxResultado.Text[textBoxResultado.Text.Length - 1].ToString(), out d))
                {
                    OperacionAnterior = Operacion.Nada;
                }
                textBoxResultado.Text = textBoxResultado.Text.Remove(textBoxResultado.Text.Length - 1, 1);
            }
        }
        //Boton dividir
        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (OperacionAnterior != Operacion.Nada)
                Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Div;
            textBoxResultado.Text += (sender as Button).Text;
            Agrandar();
            esComa = false;
        }
        //Boton multiplicacion
        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (OperacionAnterior != Operacion.Nada)
                Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Mul;
            textBoxResultado.Text += (sender as Button).Text;
            Agrandar();
            esComa = false;
        }
        //Boton restar
        private void buttonRestar_Click(object sender, EventArgs e)
        {
            if (OperacionAnterior != Operacion.Nada)
                Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Res;
            textBoxResultado.Text += (sender as Button).Text;
            Agrandar();
            esComa = false;
        }
        //Boton sumar
        private void buttonSumar_Click(object sender, EventArgs e)
        {
            if (OperacionAnterior != Operacion.Nada)
                Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Sum;
            textBoxResultado.Text += (sender as Button).Text;
            Agrandar();
            esComa = false;
        }
        //Operar con los numeros
        private void Calcular(Operacion operacionAnterior)
        {
            List<double> PriNums = new List<double>();
            switch (operacionAnterior)
            {
                //Resta
                case Operacion.Res:
                    try
                    {
                        PriNums = textBoxResultado.Text.Split('-').Select(double.Parse).ToList();
                        textBoxResultado.Text = (PriNums[0] - PriNums[1]).ToString();
                    }
                    catch (FormatException)
                    {
                        muerto();
                    }
                    break;
                //Sumar
                case Operacion.Sum:
                    try
                    {
                        PriNums = textBoxResultado.Text.Split('+').Select(double.Parse).ToList();
                        textBoxResultado.Text = (PriNums[0] + PriNums[1]).ToString();
                    }
                    catch (FormatException)
                    {
                        muerto();
                    }
                    break;
                //Multiplicar
                case Operacion.Mul:
                    try
                    {
                        PriNums = textBoxResultado.Text.Split('*').Select(double.Parse).ToList();
                        textBoxResultado.Text = (PriNums[0] * PriNums[1]).ToString();
                    }
                    catch (FormatException)
                    {
                        muerto();
                    }
                    break;
                //Porcentaje
                case Operacion.Por:
                    try
                    {
                        PriNums = textBoxResultado.Text.Split('%').Select(double.Parse).ToList();
                        textBoxResultado.Text = ((PriNums[0] * PriNums[1]) / 100).ToString();
                    }
                    catch (FormatException)
                    {
                        muerto();
                    }
                    break;
                //Coma
                case Operacion.Coma:
                    PriNums = textBoxResultado.Text.Split(',').Select(double.Parse).ToList();
                    break;
                //Division
                case Operacion.Div:
                    try
                    {
                        PriNums = textBoxResultado.Text.Split('÷').Select(double.Parse).ToList();
                        if (PriNums[0] != 0 && PriNums[1] != 0)
                        {
                            textBoxResultado.Text = (PriNums[0] / PriNums[1]).ToString();
                        }
                        else
                        {
                            muerto();
                        }
                    }
                    catch (FormatException)
                    {
                        muerto();
                    }
                    break;
                case Operacion.Nada:
                    break;
                default:
                    break;
            }
        }
        //Todos los numeros
        private void buttonNumero_Click(object btn, EventArgs e)
        {
            textBoxResultado.Text += (btn as Button).Text;
            Empequeñecer();
        }
        //Abreviaciones operaciones
        enum Operacion
        {
            Res,
            Sum,
            Mul,
            Div,
            Por,
            Coma,
            Nada
        }
        static Operacion OperacionAnterior = Operacion.Nada;

        //Encender la calculadora
        public void encender()
        {
            textBoxResultado.Enabled = true;
            buttonEncender.Enabled = false;
            buttonApagar.Enabled = true;
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonSumar.Enabled = true;
            buttonLimpiar.Enabled = true;
            buttonReiniciar.Enabled = true;
            buttonComa.Enabled = true;
            buttonCopiar.Enabled = true;
            buttonMultiplicacion.Enabled = true;
            buttonDividir.Enabled = true;
            buttonRestar.Enabled = true;
            buttonResultado.Enabled = true;
            buttonPorcentaje.Enabled = true;
            label1.ForeColor = Color.LimeGreen;
            buttonReiniciar.ForeColor = Color.LimeGreen;
            buttonCopiar.ForeColor = Color.LimeGreen;
            textBoxResultado.ForeColor = Color.LimeGreen;
            buttonApagar.ForeColor = Color.LimeGreen;
            Agrandar();
        }
        //Apagar la calculadora
        public void apagar()
        {
            textBoxResultado.Enabled = false;
            buttonEncender.Enabled = true;
            buttonApagar.Enabled = false;
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonSumar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonReiniciar.Enabled = false;
            buttonComa.Enabled = false;
            buttonCopiar.Enabled = false;
            buttonMultiplicacion.Enabled = false;
            buttonDividir.Enabled = false;
            buttonRestar.Enabled = false;
            buttonResultado.Enabled = false;
            buttonPorcentaje.Enabled = false;
            OperacionAnterior = Operacion.Nada;
            label1.ForeColor = Color.LimeGreen;
            textBoxResultado.Clear();
            esComa = false;
            Agrandar();
        }
        //The calculator muerta por excepciones
        public void muerto()
        {
            textBoxResultado.Text = "The Calculator ha muerto";
            textBoxResultado.Enabled = true;
            buttonEncender.Enabled = false;
            buttonApagar.Enabled = true;
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonSumar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonReiniciar.Enabled = true;
            buttonComa.Enabled = false;
            buttonCopiar.Enabled = true;
            buttonMultiplicacion.Enabled = false;
            buttonDividir.Enabled = false;
            buttonRestar.Enabled = false;
            buttonResultado.Enabled = false;
            buttonPorcentaje.Enabled = false;
            OperacionAnterior = Operacion.Nada;
            label1.ForeColor = Color.Red;
            buttonReiniciar.ForeColor = Color.Red;
            buttonCopiar.ForeColor = Color.Red;
            textBoxResultado.ForeColor = Color.Red;
            buttonApagar.ForeColor = Color.Red;
        }
        //Empequeñecer el texto si se sale del textbox
        public void Empequeñecer()
        {
            int recuento = textBoxResultado.Text.Length;
            if (recuento > 22)
                textBoxResultado.Font = new System.Drawing.Font("Stencil", 20, FontStyle.Regular);
            if (recuento > 32)
                textBoxResultado.Font = new System.Drawing.Font("Stencil", 18, FontStyle.Regular);
        }
        //Agrandar el texto si no se sale del textbox
        public void Agrandar()
        {
            int recuento = textBoxResultado.Text.Length;
            if (recuento <= 22)
                textBoxResultado.Font = new System.Drawing.Font("Stencil", 28, FontStyle.Regular);
            else
            if (recuento <= 32)
                textBoxResultado.Font = new System.Drawing.Font("Stencil", 20, FontStyle.Regular);
        }
     
        //Boton encender
        private void buttonEncender_Click(object sender, EventArgs e)
        {
            encender();
        }
        //Boton resultado (igual)
        private void buttonResultado_Click_1(object sender, EventArgs e)
        {
            Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Nada;
            esComa = false;
            Agrandar();
        }
        //Boton apagar
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            apagar();
        }
        //Boton porcentaje
        private void buttonPorcentaje_Click(object sender, EventArgs e)
        {
            if (OperacionAnterior != Operacion.Nada)
                Calcular(OperacionAnterior);
            OperacionAnterior = Operacion.Por;
            textBoxResultado.Text += (sender as Button).Text;
            Agrandar();
        }
        //Boton coma
        private void buttonComa_Click_1(object sender, EventArgs e)
        {
            if (esComa == false)
                textBoxResultado.Text += (sender as Button).Text;
            esComa = true;
            Agrandar();
        }
    }
}

