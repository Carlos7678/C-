using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaPuertas
{
    public class Puerta
    {
        // Atributos de la clase puerta
        protected int ancho; //ancho en cms
        protected int alto;
        protected string color;
        protected bool abierta; //si este parametro es true la puerta esta abierta y en caso contrario estará cerrada y no se podra entrar
        protected int numPuerta;//indica el nº de la puerta que hemos creado
        
        public Puerta() //constructor sin argumentos
        {
            Console.WriteLine("Creando el objeto puerta sin nada dentro");
        }
        public Puerta(int anch,int alt,string col,int nPuerta)//constructor con argumento
        {
            Console.WriteLine("Creando el objeto puerta e incializando atributos");
            this.ancho = anch;
            this.alto = alt;
            this.color = col;
            this.numPuerta = nPuerta;
        }
        public Puerta(int anch, int alt, string col, bool abiert)//constructor con argumento
        {
            Console.WriteLine("Creando el objeto puerta e incializando atributos");
            this.ancho = anch;
            this.alto = alt;
            this.color = col;
            this.abierta=abiert;
        }
        //metodos

        public void mostrarEstado()
        {
            Console.WriteLine();
            Console.WriteLine("ESTADO");
            Console.WriteLine("-------");
            Console.WriteLine("PUERTA nº"+numPuerta);
            Console.WriteLine("Ancho " + ancho);
            Console.WriteLine("Alto " + alto);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Abierta " + abierta);
            Console.WriteLine();
        }
        public void setId(byte identificador)
        { 
        }

        public void abrir_puerta()
        {
            abierta = true;
        }
        public void cerrar_puerta()
        {
            abierta = false;
        }

        public void entrar()
        {
            if (abierta == false)
            
                Console.WriteLine("No has podido entrar la puerta estaba cerrada y no eres capaz de abrir la puerta");
            
            else  
                Console.WriteLine("Has entrado porque la puerta estaba abierta"); 
        }
        public virtual void calcularAreaPuerta()
        {
            int area = alto * ancho;
            Console.WriteLine("El area de la puerta {0} es {1}",numPuerta,area);
                }
        }
    }
    




