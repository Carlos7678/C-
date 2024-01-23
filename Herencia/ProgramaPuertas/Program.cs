using System;

namespace ProgramaPuertas
{
    class Program
    {
        static int anchura;
        static int altura;
        static string color;

        static void pausa()
        {
            Console.WriteLine("Press any to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
/*          Puerta p = new Puerta();
            Console.WriteLine("Mostrando estado");
            p.mostrarEstado();
            pausa();

            Console.WriteLine("Creando una puerta");
            Puerta p1 = new Puerta(50, 100, "negro", 1);
            Console.WriteLine("Creando una segunda puerta");
            Puerta p2 = new Puerta(35, 200, "blanco", 2);

            pausa();

            //mostrando estados de las puertas
            Console.WriteLine("Mostrando estado de la puerta 1");
            p1.mostrarEstado();
            Console.WriteLine("Mostrando estado de la puerta 2");
            p2.mostrarEstado();

            pausa();

            //abriendo puertas
            Console.WriteLine("Abriendo puertas y mostrando los estados");
            p1.abrirPuerta();
            p2.abrirPuerta();
            Console.WriteLine();
            p1.mostrarEstado();
            p2.mostrarEstado();

            pausa();

            Console.WriteLine("Entrando por las puertas");
            p1.entrar();
            p2.entrar();
            p1.cerrarPuerta();
            p1.entrar();

            pausa();

            //Creando arrays de puertas
            Console.WriteLine("Introduzca el número de puertas");
            int numPuertas = int.Parse(Console.ReadLine());
            Puerta[] puertas = new Puerta[1000];
            for (int i = 0; i < numPuertas; i++)
            {
                Console.WriteLine("Introduzca datos de la puerta " + (i + 1));
                Console.WriteLine("Introduzca el ancho");
                anchura = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el alto");
                altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el color");
                color = Console.ReadLine();
                puertas[i] = new Puerta(anchura, altura, color, (i + 1));
            }



            //Calcular area puerta 1
            Console.WriteLine("Calculamos el área de la primera puerta");
            puertas[0].calcularAreaPuerta();

            //Mostrar estado de la primera puerta
            Console.WriteLine("Mostrar el estado de la primera puerta");
            puertas[0].mostrarEstado();
            pausa();

            //mostrar estado de todas las puertas
            for (int i = 0; i < numPuertas; i++)
            {
                puertas[i].mostrarEstado();
            }

            //Abrimos todas las puertas
            Console.WriteLine("Abrimos todas las puertas");
            for (int i = 0; i < numPuertas; i++)
            {
                puertas[i].abrirPuerta();
                puertas[i].mostrarEstado();
            }

            Console.WriteLine("Abrimos a intentar entrar");
            for (int i = 0; i < numPuertas; i++)
            {
                Console.WriteLine("Puerta nº " + (i + 1));
                puertas[i].entrar();

            }
            
*/
            //Creando Portones
            Console.WriteLine("Vamos a crear un portón");
            Porton pt1 = new Porton(1, 50, 222, "gris");
            pt1.mostrarEstado();
            pt1.calcularAreaPuerta();
            pt1.bloquear();

            Console.WriteLine("Vamos a crear otro portón");
            Puerta pt2 = new Porton(2, 60, 444, "azul");
            pt2.mostrarEstado();
            pt2.calcularAreaPuerta();
            //pt2.bloquear();



        }
    }
}
