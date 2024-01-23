using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class ClaseDerivada:ClaseBase 
    {
        /*public override void Metodo1()
       {
            Console.WriteLine("Método 1.Clase derivada");
        }*/
        public new void Metodo2()
        {
            Console.WriteLine("Método 2.Clase derivada");
        }

        public void Metodo4()
        {
            Console.WriteLine("Método 4.Clase derivada");
        }
        public virtual void MostrarDetalle()
        {
            Console.WriteLine("ESTAMOS EN LA CLASE DERIVADA");
        }
    }
}
