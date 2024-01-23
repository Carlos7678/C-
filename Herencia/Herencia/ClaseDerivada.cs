using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class ClaseDerivada: ClaseBase
    {
        //public override void Metodo1() //sobreescribe el metodo del padre, el cual es virtual
        //{
        //    Console.WriteLine("Método 1. Clase Derivada");
        //}

        public new void Metodo2() // añadir new para indicar que este método ya lo tiene el padre y así lo oculta
        {
            Console.WriteLine("Método 2. Clase Derivada");
        }

        public void Metodo4()
        {
            Console.WriteLine("Método 4. Clase Derivada");
        }

        public override void MostrarDetalle()
        {
            Console.WriteLine("Estamos en la clase derivada");
        }

    }
}
