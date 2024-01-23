using System;

namespace Coche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test coches");
            Console.WriteLine("-----------");

            Coche coche1 = new Coche();
            coche1.DescribreCoche();
            Console.WriteLine("-----------");

            Deportivo coche2 = new Deportivo();
            coche2.DescribreCoche();
            coche2.MostrarDetalleCoche();
            Console.WriteLine("-----------");

            Electrico coche3 = new Electrico();
            coche3.DescribreCoche();
            Console.WriteLine("-----------");

            Coche coche4 = new Deportivo();
            coche4.DescribreCoche();
            coche4.MostrarDetalleCoche();
            Console.WriteLine("-----------");

            Coche coche5 = new Electrico();
            coche5.DescribreCoche();
            coche5.MostrarDetalleCoche();
            Console.WriteLine("-----------");




        }
    }
}
