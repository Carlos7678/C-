using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class ClaseBase
    {
        public virtual void Metodo1()
        {
            Console.WriteLine("Método 1. Clase Base");
            MostrarDetalle();
        }
        
        public void Metodo2()
        {
            Console.WriteLine("Método 2. Clase Base");
        }

        public void Metodo3()
        {
            Console.WriteLine("Método 3. Clase Base");
        }


        public virtual void MostrarDetalle()
        {
            Console.WriteLine("Aun estamos en la clase base");            
        }

    }
}
