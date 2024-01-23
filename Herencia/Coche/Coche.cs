using System;
using System.Collections.Generic;
using System.Text;

namespace Coche
{
    class Coche
    {
        public void DescribreCoche()
        {
            Console.WriteLine("4 ruedas, carrocería y motor");
            MostrarDetalleCoche();
        }

        public virtual void MostrarDetalleCoche()
        {
            Console.WriteLine("Sirve para el transporte de personas y equipaje");
        }


    }

    class Deportivo : Coche
    {
        public new void MostrarDetalleCoche()
        {
            Console.WriteLine("Más potencia");
        }
    }

    class Electrico : Coche
    {
        public override void MostrarDetalleCoche()
        {
            Console.WriteLine("Más ecológico");
        }
    }
}
