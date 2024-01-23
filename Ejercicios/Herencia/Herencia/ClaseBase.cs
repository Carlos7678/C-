using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class ClaseBase
    {
        public virtual void Metodo1()
        {
            Console.WriteLine("Método 1.Clase base");
            MostrarDetalle();
        }
        public void Metodo2()
        {
            Console.WriteLine("Método 2.Clase base");
        }

        public void Metodo3()
        {
            Console.WriteLine("Método 3.Clase base");
        }
        public void MostrarDetalle()
        {
            Console.WriteLine("AUN ESTAMOS EN LA CLASE BASE");
        }
    }
}
