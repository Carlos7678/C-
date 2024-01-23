using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_entornos
{
    class Coches { 
   private string modelo;
    private string marca;
    private string color;
    private int cilindrada;
    private bool aireAcondicionado;
        bool pintado = false;

        public Coches(string modelo, string marca, string color, int cilindrada, bool aireAcondicionado)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.color = color;
        this.cilindrada = cilindrada;
        this.aireAcondicionado = aireAcondicionado;
    }

    public String cochesImprimir()
    {
        String taire = "";

        if (aireAcondicionado)
        {
            taire = "Con aire acondicionado";
        }
        else
        {
            taire = "Sin aire acondicionado";
        }


        String lista = "Modelo: " + modelo + "\n" + "Marca: " + marca + "\n" + "Color: "+color + "\n" + "Cilindrada: "+cilindrada + "\n" + taire + "\n";

        return lista;
    }

    public bool getAire()
    {
        if (aireAcondicionado)
        {
            return true;
        }
        return false;
    }

    public void setAire()
    {
        aireAcondicionado = true;
    }
 
    }
}
