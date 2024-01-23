using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaPuertas
{
    public class Puerta
    {
        //Atributos de la clase puerta
        protected int ancho; //ancho en cm
        protected int alto; //alto en cm
        protected string color;
        protected bool abierta; //si este parámero es true la puerta está abierta, en caso contrario estará cerrada y no se podrá entrar
        protected int numPuerta; //indica el número de la puerta que hemos creado

        public Puerta() //Constructor sin argumentos
        {
            Console.WriteLine("Creando el objeto puerta sin nada dentro");
        }

        public Puerta(int anch, int alt, string col, int nPuerta) //Constructor con argumentos
        {
            Console.WriteLine("Creando el objeto e inicializando atributos");
            ancho = anch;
            alto = alt;
            color = col;
            numPuerta = nPuerta;
        }

        public Puerta(int anch, int alt, string col, bool abiert) //Constructor con argumentos
        {
            Console.WriteLine("Creando el objeto e inicializando atributos");
            ancho = anch;
            alto = alt;
            color = col;
            abierta = abiert;
        }

        //Métodos

        public virtual void mostrarEstado()
        {
            Console.WriteLine();
            Console.WriteLine("ESTADO");
            Console.WriteLine("------");
            Console.WriteLine("Puerta nº " + numPuerta);
            Console.WriteLine("Ancho: " + ancho);
            Console.WriteLine("Alto: " + alto);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Abierta: " + abierta);
            Console.WriteLine();
        }

        public void setID(byte identificador)
        {
            numPuerta = identificador;
        }

        public void abrirPuerta()
        {
            abierta = true;
        }

        public void cerrarPuerta()
        {
            abierta = false;
        }

        public void entrar()
        {
            if (abierta)
            {
                Console.WriteLine("Entrada permitida");
            }
            else
            {
                Console.WriteLine("Entrada no permitida");
            }
        }

        public virtual void calcularAreaPuerta()
        {
            Console.WriteLine("La puerta {0} tiene un área de: {1}", numPuerta, (alto * ancho));
        }



    }
}
