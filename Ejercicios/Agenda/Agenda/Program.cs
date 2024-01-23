// See https://aka.ms/new-console-template for more information
using Agenda;
 
static void Pause ()
{
    Console.WriteLine("Pulse una tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}

static int menu()
{
    int opcion;
    Console.WriteLine("1. Insertar contacto");
    Console.WriteLine("2. Visualizar agenda");
    Console.WriteLine("3. Borrar contacto");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Escoge una opción");
    opcion =int.Parse(Console.ReadLine());
    return opcion;

    switch (opcion)     
    {
        case 1:
            break;

            case 2:
            break;

            case 3:
            break;

        case 4:
            break;

        default:
            break;
    }
}

static Contacto nuevoContacto()
{
    string nombre, ap1, ap2, telefonoMovil,dni;
    Console.WriteLine("Introduce el nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Introduce el primer apellido");
    ap1 = Console.ReadLine();
    Console.WriteLine("Introduce el segundo apellido");
    ap2 = Console.ReadLine();
    Console.WriteLine("Introduce el teléfono móvil");
    telefonoMovil = Console.ReadLine();
    Console.WriteLine("Introduce el DNI");
    dni= Console.ReadLine();
    Contacto nuevo = new Contacto(nombre, ap1, ap2, telefonoMovil,dni);
    return nuevo;
}
 
static void insertar(Contacto[]ag,ref int nTotal,Contacto nuevo)
{ 
    ag[nTotal] = nuevo;
    nTotal++;
}
static void mostrar(Contacto[]ag,int nTotal)
{
    for(int i = 0; i < nTotal; i++)
    {
        Console.WriteLine("Nombre\t\tApellido1\t\tApellido2\t\tTelefono Movil\t\tDNI");
        Console.WriteLine("{0}\t\t{0}\t\t{0}\t\t{0}\t\t{0}", ag[i].getNombre(),
            ag[i].getApellido1(), ag[i].getApellido2(), ag[i].getTelFijo(),ag[i].getDni());
    }
}

static void Main(string[] args)
{
    const int TAM_MAX = 100;
    int numeroElementos = 0;
    int op = 0;

    Contacto[] agenda=new Contacto[TAM_MAX];
    do
    {
        op = menu();
        switch (op)
        {
            case 1:
                Contacto n = nuevoContacto();
                insertar(agenda, ref numeroElementos, n);
                break;
            case 2:
                mostrar(agenda, numeroElementos);
                break;
        }
        Console.ReadLine();
    } while (op != 3);
}
