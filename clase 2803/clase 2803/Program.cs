
using System.Xml;
bool salir = true;

int aprobados = 0;
int desaporbados = 0;
do
{
    Console.WriteLine("menu principal");
    Console.WriteLine("1- ingreso de cantidad fija de notas");
    Console.WriteLine("2- ingreso indefinido de notas");
    Console.WriteLine("3- mostar resumen");
    Console.WriteLine("4- salir");
    Console.WriteLine("selecicone una opcion");

    string opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            ingresosFijos();
            break;
        case "2":
            ingresoIndefinido();
            break;
        case "3":
            mostrarResuman();
            break;
        case "4":
            Console.WriteLine("saliendo");
            salir = false;
            break;

        default:
            Console.WriteLine("opcion invalida");
            break;
    }
}while(salir);
void ingresosFijos()
{
    Console.WriteLine("Cuantas notas desea ingrsar.");

    int cantidad = int.Parse(Console.ReadLine());
    int nota;
    for (int i = 0; i < cantidad; i++)
    {
        Console.WriteLine("Ingrese la nota del estudiante.");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 6)
        {
            Console.WriteLine("Aprobado");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Desaprobo");
            desaporbados++;
        }
    }

}

void ingresoIndefinido()
{
    int nota;
    string respuesta;
    respuesta = "si";

    while (respuesta == "si")
    {
        Console.WriteLine("ingrese nota del estudiante");
        nota= int.Parse(Console.ReadLine());

        if (nota > 6)
        {
            Console.WriteLine("Aprobado");
            aprobados++;
        }
        else
        {
            Console.WriteLine("Desaprobo");
            desaporbados++;
        }
        Console.WriteLine("desea ingresar otra nota? (si/no)");
        respuesta = Console.ReadLine();
    }
}

void mostrarResuman()
{
    Console.WriteLine("Cantidad de aprobados: "+ aprobados);
    Console.WriteLine("Cantidad de desaprobados: " + desaporbados);
    Console.ReadKey();
}