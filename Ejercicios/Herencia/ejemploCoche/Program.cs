using System;

namespace ejemploCoche
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Test coches");
            Console.WriteLine("------------");

            Coche coche1 = new Coche();
            coche1.DescribeCoche();
            Console.WriteLine("------");

            Deportivo coche2 = new Deportivo();
            coche2.DescribeCoche();
            Console.WriteLine("------");
            Electrico coche3 = new Electrico();
            coche3.DescribeCoche();
            Console.WriteLine("------");
        }
    }
}