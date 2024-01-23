using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploCoche
{
    class Coche
    {
        public void DescribeCoche()
        {
            Console.WriteLine("4 ruedas,carrocería y motor");
        }
        public virtual void MostrarDetalleCoche()
        {
            Console.WriteLine("Sirve para el transporte de personas y mercancías");
        }
    }
    class Deportivo : Coche
    {
        public new void MostrarDetalleCoche()
        {
            Console.WriteLine("Mas potencia");
        }
    }
    class Electrico : Coche
    {
        public override void MostrarDetalleCoche()
        {
            Console.WriteLine("Más ecologico");
        }
    }
}