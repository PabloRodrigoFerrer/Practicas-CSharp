using System.Runtime.InteropServices;

namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int[] vAcu = new int[15];
        int art, cantidadVendida, max, pos;

        for (int x = 0; x < 15; x++)
            vAcu[x] = 0;

        Console.WriteLine("Ingrese el numero de articulo: ");
        art = int.Parse(Console.ReadLine());
        while (art != 0)
        {
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            vAcu[art - 1] += cantidadVendida;

            Console.WriteLine("Ingrese el numero de articulo: ");
            art = int.Parse(Console.ReadLine());
        }

        max = vAcu[0];
        pos = 1;

        Console.WriteLine("Los siguientes articulos no tienen ventas: ");
        for (int x = 0; x < 15; x++)
        {   //punto a
            if (vAcu[x] >= max)
            {
                max = vAcu[x];
                pos = x + 1;
            }
            //punto b
            if (vAcu[x] == 0)
                Console.Write(+(x + 1) + ", ");
        }

        Console.WriteLine("\nEl articulo 10 ha vendido: " + vAcu[9]); // punto c
        Console.WriteLine("La posición del articulo con mas ventas es: " + pos + " y vendio: " + max);

    }
}
