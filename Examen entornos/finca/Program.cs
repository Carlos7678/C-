using System;

namespace finca
{
    class añadirFinca
    {
        static void Main(string[] args)
        {
            fincas[] matF = new fincas[100];
            int indexF = 0;
            int opcion = 0;

            while (opcion != 5)
            {
                opcion = menu();
                
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Número de fincas a introducir");
                        int nFincas = int.Parse(Console.ReadLine());

                        for (int i = 0; i < nFincas; i++)
                        {
                            matF[indexF] = añadirF();
                            Console.WriteLine("Datos de la finca " + indexF );
                            Console.WriteLine(matF[indexF].fincasImprimir());
                            indexF += 1;
                        }
                        break;

                    case 2: 
                        int contnull = 0;
                        for (int i = 0; i < matF.Length; i++)
                        {
                            if (matF[i] != null)
                            {
                                contnull += 1;
                            }
                            else
                            {
                                i = matF.Length;
                            }
                        }

                        for (int i = 0; i < contnull; i++)
                        {
                            Console.WriteLine("Datos de la finca " + i);
                            Console.WriteLine(matF[i].fincasImprimir());
                        }
                        break;


                    case 3:                       
                        if (matF[0] != null)
                        {
                            Console.WriteLine("Introduzca la finca:");
                            int num = int.Parse(Console.ReadLine());
                            if (matF[num - 1] != null)
                            {
                                if (matF[num - 1].getConserje())
                                {
                                    Console.WriteLine("ya hay un conserje");
                                }
                                else
                                {
                                    matF[num - 1].setConserje();
                                }
                            }
                            else
                            {
                                Console.WriteLine("No existe la finca");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay ninguna finca");
                        }
                        break;

                    case 4:                       
                        matF[indexF] = añadirF();
                        Console.WriteLine(matF[indexF].fincasImprimir());
                        indexF += 1;
                        break;
                    case 5:
                        break;
                }

            }

        }

        private static int menu()
        {
            int opcion = 0;
            Console.WriteLine("1. Dar de alta finca\n"
                + "2. Ver caracteristicas finca\n" +
                "3. Contratar un conserje\n" +
                "4. Dar de alta una finca\n" +
                "5. Salir");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        private static fincas añadirF() //añadir finca
        {
            Console.WriteLine("Datos finca");
            Console.WriteLine("Introducir número de puertas");
            int nPuertas = int.Parse(Console.ReadLine());    //al poner un try catch me daba error de compilación y he decidido dejarlo 
            Console.WriteLine("número de plantas");
            int nPlantas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Tiene garaje <si o no>?");
            String garaje = Console.ReadLine();
            bool garajeB = false;
            if (garaje.Equals("si") || garaje.Equals("SI") || garaje.Equals("Si")) //si pone cualquier cosa que no sea si, contaria como null
            {
                garajeB = true;
            }
            Console.WriteLine("¿Tiene conserje <si o no>?");
            String conserje = Console.ReadLine();
            bool conserjeB = false;
            if (garaje.Equals("si") || garaje.Equals("SI") || garaje.Equals("Si"))
            {
                conserjeB = true;
            }
            Console.WriteLine("");
            return new fincas(nPuertas, nPlantas, garajeB, conserjeB);
        }
    }
}
