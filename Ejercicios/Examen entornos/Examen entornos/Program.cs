using System;

namespace Examen_entornos
{
    class añadirCoche
    {
        static void Main(string[] args)
        {
            Coches[] matF = new Coches[100];
            int indexF = 0;
            int opcion = 0;

            while (opcion != 5)
            {
                opcion = menu();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("CREAR COCHES.");
                        int nCoches;
                        try
                        {
                            Console.WriteLine("Número de coches a crear");
                            nCoches = int.Parse(Console.ReadLine());
                            for (int i = 0; i < nCoches; i++)
                            {
                                matF[indexF] = añadirC();
                                Console.WriteLine("Datos del Coche " + indexF);
                                Console.WriteLine(matF[indexF].cochesImprimir());
                                indexF += 1;
                            }
                            if (nCoches < 0)
                            {
                                Console.WriteLine("Introduce un numero positivo");
                            }
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Introduce un numero valido");


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
                            Console.WriteLine("Datos del coche " + i);
                            Console.WriteLine(matF[i].cochesImprimir());
                        }
                        break;


                    case 3:

                        if (matF[0] != null)
                        {
                            Console.WriteLine("Introduzca el coche:");
                            int num = int.Parse(Console.ReadLine());
                            if (matF[num - 1] != null)
                            {
                                //if (matF[num - 1])
                                //{
                                    
                                //}
                                //else
                                //{
                                //    matF[num - 1];
                                //}
                            }
                            else
                            {
                                Console.WriteLine("No existe el coche");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay ningun coche");
                        }
                        break;


                    case 4:
                        matF[indexF] = añadirC();
                        Console.WriteLine(matF[indexF].cochesImprimir());
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
            Console.WriteLine("1. Crear coches\n"
                + "2. Ver caracteristicas de todos los coches\n" +
                "3. Pintar un coche\n" +
                "4. Insertar coche\n" +
                "5. Salir\n"+
                "6. Modificar coche"+
                "7.Buscar coche por modelo");
            opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        private static Coches añadirC() 
        {

            Console.WriteLine("CREAR COCHES");
            Console.WriteLine("Introducir modelo");
            string modelo = Console.ReadLine();    
            Console.WriteLine("Introducir marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Introducir color");
            String color = Console.ReadLine();
            Console.WriteLine("Introducir cilindrada");
            int cilindrada = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Tiene aire acondicionado <si o no>?");
            String aire = Console.ReadLine();
            bool aireC = false;
            if (aire.Equals("si") || aire.Equals("SI") || aire.Equals("Si"))
            {
                aireC = true;
            }
            Console.WriteLine("");
            return new Coches(modelo, marca,color, cilindrada, aireC);
        }
        private static string añadirColor()
        {
            Console.WriteLine("Introduce el nuevo color");
            String color = Console.ReadLine();
            return color;
        
        }
    }
}
