using System;
using System.Collections.Generic;
using System.Text;

namespace finca
{
    class fincas
    {
        private int numPuertas;
        private int numPlantas;
        private bool garaje;
        private bool conserje;

        public fincas(int numPuertas, int numPlantas, bool garaje, bool conserje)
        {
            this.numPuertas = numPuertas;
            this.numPlantas = numPlantas;
            this.garaje = garaje;
            this.conserje = conserje;
        }

        public String fincasImprimir() {
            String tgaraje = "";
            String tconserje = "";

            if (garaje)
            {
                tgaraje = "Con garaje";
            }
            else
            {
                tgaraje = "Sin garaje";
            }

            if (conserje)
            {
                tconserje = "Con conserje";
            }
            else
            {
                tconserje = "Sin conserje";
            }
            
            String lista =  "Puertas: " + numPuertas+"\n"+ "Plantas: "+numPlantas + "\n" + tgaraje + "\n" + tconserje + "\n";

            return lista;
        }

        public bool getConserje() {
            if (conserje)
            {
                return true;
            }
            return false;
        }

        public void setConserje() {
            conserje = true;
        }

    }
}
