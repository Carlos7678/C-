using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPuertas
{
    public class Porton : Puerta
    {
        Boolean bloqueado;

        public Porton()
        {
            Console.WriteLine("Creando portón sin ningún atributo");
        }
        public Porton(int anchoPorton, int altoPorton, string colorPorton)
        {
            Console.WriteLine("Creando portón a partir de los atributos de puerta");
            ancho = anchoPorton;
            alto = altoPorton;
            color = colorPorton;
        }

        public Porton(int numPuerta,int anchoPorton, int altoPorton, string colorPorton)
        {
            Console.WriteLine("Creando portón a partir de los atributos de puerta");
            this.numPuerta = numPuerta;
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
        public new void mostrarEstado()
        {
            Console.WriteLine();
            Console.WriteLine("Estado");
            Console.WriteLine("----");
            Console.WriteLine("Portón nº " + numPuerta);
            Console.WriteLine("Ancho " + ancho);
            Console.WriteLine("Alto " + alto);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Abierta " + abierta);
            Console.WriteLine("Bloqueado " + bloqueado);
            Console.WriteLine();
        }

        public override void calcularAreaPuerta()
        {
            int area = ancho * alto;
            Console.WriteLine("El área del portón "+numPuerta+" es "+area);
        }


    }
}