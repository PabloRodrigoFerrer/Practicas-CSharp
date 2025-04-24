using System.Net.Http.Headers;

namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int numero, contPrimo = 0;

        for (int x = 0; x < 10; x++)
        {
            int contDivs = 0;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            for (int y = 1; y <= numero; y++)
            {
                if (numero % y == 0)
                    contDivs++;
            }

            if (contDivs == 2)
                contPrimo++;
        }

        Console.WriteLine("La cantidad de numero primos es: " + contPrimo);
    }
}
