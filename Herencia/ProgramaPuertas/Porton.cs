using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaPuertas
{
    public class Porton: Puerta
    {
        private bool bloqueado;

        public Porton()
        {
            Console.WriteLine("Creando porton sin ningún atributo");
        }

        public Porton(int nPuerta, int anchoPorton, int altoPorton, string colorPorton)
        {
            Console.WriteLine("Creando Portón a partir de los atributos de Puerta");
            numPuerta = nPuerta;
            ancho = anchoPorton;
            alto = altoPorton;
            color = colorPorton;
        }

        //Métodos
        public void bloquear()
        {
            bloqueado = true;
        }

        public void desbloquear()
        {
            bloqueado = false;                 
        }

        public override void mostrarEstado()
        {
            Console.WriteLine();
            Console.WriteLine("ESTADO");
            Console.WriteLine("------");
            Console.WriteLine("Portón nº " + numPuerta);
            Console.WriteLine("Ancho: " + ancho);
            Console.WriteLine("Alto: " + alto);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Abierta: " + abierta);
            Console.WriteLine("Bloqueado: " + bloqueado);
            Console.WriteLine();
        }

        public override void calcularAreaPuerta()
        {
            int area = ancho * alto;
            Console.WriteLine("El área del portón " + numPuerta + " es " + area);
        }


    }
}
