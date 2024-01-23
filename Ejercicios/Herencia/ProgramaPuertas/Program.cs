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
        static void Main(String[] args)
        {
            Puerta p = new Puerta();
            Console.WriteLine("Mostrando estado");
            p.mostrarEstado();
            pausa();

            Console.WriteLine("Creando una puerta");
            Puerta p1 = new Puerta(50, 100, "negro", 1);
            Console.WriteLine("Creando una puerta");
            Puerta p2 = new Puerta(35, 200, "blanco", 2);
            pausa();
            //mostrar estado de las puertas
            Console.WriteLine("Mostrando estado de la puerta 1");
            p1.mostrarEstado();

            Console.WriteLine("Mostrando estado de la puerta 2");
            p2.mostrarEstado();


            pausa();
            Console.WriteLine("Abriendo puertas y mostrando los estados");
            p1.abrir_puerta();
            p2.abrir_puerta();
            Console.WriteLine();
            p1.mostrarEstado();
            p2.mostrarEstado();

            pausa();

            Console.WriteLine();
            p1.entrar();
            p2.entrar();
            p1.cerrar_puerta();
            p1.entrar();

            pausa();

            ////creando array de objetos e instrucción de datos
            //Console.WriteLine("Introduzca el número de puertas");
            //int numPuertas = int.Parse(Console.ReadLine());
            //Puerta[] misPuertas = new Puerta[10];
            //for (int i = 0; i < numPuertas; i++)
            //{
            //    Console.WriteLine("Introduzca datos de la puerta " + (i + 1));
            //    Console.WriteLine("Introduzca el ancho");
            //    anchura = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Introduzca el alto");
            //    altura = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Introduzca el alto");
            //    color = Console.ReadLine();
            //    misPuertas[i] = new Puerta(anchura, altura, color, i + 1);

            //}
            //Console.WriteLine("Calculamos el área de la primera puerta");
            //misPuertas[0].calcularAreaPuerta();
            //Console.WriteLine("Mostrar el estado de la 1ª puerta");
            //misPuertas[0].mostrarEstado();
            //pausa();

            //for (int i = 0; i < numPuertas; i++)
            //{
            //    //Console.WriteLine("Mostrando estado de las puertas"+(i+1));
            //    misPuertas[i].mostrarEstado();
            //}
            //Console.WriteLine("Vamos a abrir todas las puertas");
            //for (int i = 0; i < numPuertas; i++)
            //{
            //    misPuertas[i].abrir_puerta();
            //    misPuertas[i].mostrarEstado();
            //}
            //Console.WriteLine("Vamos a intentar entrar");
            //for (int i = 0; i < numPuertas; i++)
            //{
            //    misPuertas[i].entrar();
            //}

            //Creando Portones
            Console.WriteLine("Vamos a crear un portón");
            Porton pt1 = new Porton(1,50, 222, "gris");
            pt1.setId(1);
            pt1.mostrarEstado();
            pt1.calcularAreaPuerta();
            pt1.bloquear();

            Console.WriteLine("Vamos a crear un portón");
            Puerta pt2 = new Porton(2,60, 444, "azul");
            pt2.setId(2);   
            pt2.mostrarEstado();
            pt2.calcularAreaPuerta();
            //pt2.bloquear();




        }
    }
}
