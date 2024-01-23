Console.WriteLine("1.Dar de alta varias fincas."); 
Console.WriteLine("1.Ver caracteristicas de todas las fincas.");
Console.WriteLine("3.Contratar conserje.");
Console.WriteLine("4.Dar de alta una finca.");
Console.WriteLine("5.Salir.");
int opcion=int.Parse(Console.ReadLine());
int numero;
switch (opcion)
{
    case 1:
        numero = 1;
        altaFincas();
        break;
    case 2:
        numero = 2;
        break;
    case 3:
        numero = 3;
        break;
    case 4:
        numero = 4;
        break;
    case 5:
        numero = 5;
        Environment.Exit(0);
        break;
    default:
        numero = 9;
        break;
}

 void altaFincas()
{
    int contadorfincas = 0;
    Console.WriteLine("Numeros de fincas a crear:");
    int fincasCrear = int.Parse(Console.ReadLine());
    do
    {
        Console.WriteLine("Datos de la finca" + contadorfincas);
        contadorfincas++;
        Console.WriteLine("Introducir número de puertas");
        int puertas = int.Parse(Console.ReadLine());
        Console.WriteLine("Introducir número de plantas");
        int plantas = int.Parse(Console.ReadLine());
        Console.WriteLine("¿Tiene garaje?");
        String garage = Console.ReadLine();
        Console.WriteLine("¿Tiene conserje?");
        String conserje = Console.ReadLine();
        fincasCrear--;
    } while (fincasCrear != 0);
}