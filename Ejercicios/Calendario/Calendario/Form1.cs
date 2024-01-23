using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaInicial = monthCalendar1.SelectionStart;
            DateTime fechaFinal = monthCalendar1.SelectionEnd;
            labelInicial.Text = fechaInicial.ToString();
            labelFinal.Text = fechaFinal.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2022,5,5),
                new DateTime(2022,5,11),
                new DateTime(2022,10,20),
                DateTime.Now.AddDays(5)
            };
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text=monthCalendar1.SelectionRange.Start.Day.ToString();
        }
    }
}
