using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clases bases y derivadas");
            ClaseBase bc = new ClaseBase();
            ClaseDerivada dc = new ClaseDerivada();
            ClaseBase bcdc = new ClaseDerivada(); //para aplicar los metodos de la clase instanciada hace falta hacer el override de ellos
            //ClaseDerivada dcbc = new ClaseBase(); NO ES POSIBLE

            //PRUEBAS 1
            /*Console.WriteLine("Clases y clases derivadas. Parte 1");
            bc.Metodo1();
            bc.Metodo2();
            dc.Metodo2();
            bcdc.Metodo1();*/

            //PRUEBAS 2
            Console.WriteLine("Clases y clases derivadas. Parte 2");
            Console.WriteLine();
            bc.Metodo1(); // Clase Base. Método 1
            bc.Metodo2(); // Clase Base. Método 2
            dc.Metodo1(); // Clase derivada. Método 1 --> si comentamos el método 1 de clase derivada, llamaría al método de Clase Base
            dc.Metodo2(); // Clase derivada. Método 2
            /*bcdc.Metodo1(); // Clase derivada. Método 1 --> poner virtual en el padre y override en el hijo
            bcdc.Metodo2(); // Clase base. Método 2 --> al ser new oculta el método si lo declaras como ClaseDerivada, pero al estar declarado como ClaseBase usa el método de esa clase

            bcdc.Metodo3(); // Clase base. Método 3*/
            //bcdc.Metodo4(); No puede acceder a este método porque no está en la ClaseBase




            
        }
    }
}
