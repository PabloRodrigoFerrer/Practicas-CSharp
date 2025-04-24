using System.Reflection;
using System.Timers;

namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int importe = 0;
        int opcionProcesador;
        int opcionRam;
        int opcionDisco;

        Console.WriteLine("Ingrese que procesador desea:");
        Console.WriteLine("Opcion 1: i5");
        Console.WriteLine("Opcion 2: i7");
        Console.WriteLine("Opcion 3: i9");
        opcionProcesador = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cuanta memoria RAM desea: ");
        Console.WriteLine("Opcion 1: 8GB RAM");
        Console.WriteLine("Opcion 2: 16GB RAM");
        Console.WriteLine("Opcion 3: 32GB RAM");
        opcionRam = int.Parse(Console.ReadLine());


        switch (opcionProcesador)
        {
            case 1:

                switch (opcionRam)
                {
                    case 1:
                        importe = 800;
                        break;
                    case 2:
                        importe = 900;
                        break;
                    case 3:
                        importe = 1000;
                        break;
                }
                break;
            case 2:
                switch (opcionRam)
                {
                    case 1:
                        importe = 900;
                        break;
                    case 2:
                        importe = 1000;
                        break;
                    case 3:
                        importe = 1400;
                        break;
                }
                break;
            case 3:
                switch (opcionRam)
                {
                    case 1:
                        importe = 1200;
                        break;
                    case 2:
                        importe = 1400;
                        break;
                    case 3:
                        importe = 2000;
                        break;
                }
                break;
            default:
                Console.WriteLine("Ingrese opción valida");
                break;
        }

        Console.WriteLine("El importe a abonar para las opciones CPU " + opcionProcesador + " y RAM " + opcionRam + " es de: $" + importe);
        Console.WriteLine("Desea extender el disco a 1 TB? por + 300USD");
        Console.WriteLine("Seleccione opción 1 si desea extender");
        Console.WriteLine("Seleccione opción 0 si no desea extender");
        opcionDisco = int.Parse(Console.ReadLine());

        if (opcionDisco == 1)
            importe += 300;

        Console.WriteLine("El total a abonar por su equipo es: " + importe);

    }
}
