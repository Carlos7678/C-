using System;

namespace Herencia
{
    class Program
    {
        static void Main(String[] args)
        {
            ClaseBase bc=new ClaseBase();
            ClaseDerivada dc=new ClaseDerivada();
            ClaseBase bcdc =new ClaseDerivada();

            //Pruebas 1
           /* Console.WriteLine("Clases y clases derivadas. Parte 1");
           /* bc.Metodo1();
            bc.Metodo2();
            dc.Metodo2();
            bcdc.Metodo1();*/

            Console.WriteLine("Clases y clases derivadas. Parte 2");
            Console.WriteLine();
            bc.Metodo1();  //Clase base.Método método1
            bc.Metodo2();  //Clase base.Método método2
            dc.Metodo1();  //Clase base.Método método1
            dc.Metodo2();  //Clase derivada.Método método2
           /* bcdc.Metodo1(); //Clase base.Método método1
            bcdc.Metodo2(); //Clase derivada.Método método2
            bcdc.Metodo3();  //Clase base.Método método3*/
           //bcdc.Metodo4();  //No deja acceder porque este método no está en la clase base
        }
    }
}