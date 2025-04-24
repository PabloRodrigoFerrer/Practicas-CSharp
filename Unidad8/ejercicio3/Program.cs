using System.Diagnostics;
using System.Net.Http.Headers;

namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int numero;
        float promedio, acu = 0, con = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (primo(numero))
            {
                acu += numero;
                con++;
            }
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
        }

        promedio = acu / con;
        Console.WriteLine("El promedio de los numeros primos es: " + promedio);
    }

    static bool primo(int a)
    {
        int conDivs = 0;
        for (int x = 1; x <= a; x++)
        {
            if (a % x == 0)
                conDivs++;
        }
        if (conDivs == 2)
            return true;
        else
            return false;
    }

}
