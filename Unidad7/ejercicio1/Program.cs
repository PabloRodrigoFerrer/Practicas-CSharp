using System.Security.Cryptography.X509Certificates;

namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int max, pos;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numeros[x] = int.Parse(Console.ReadLine());
        }

        max = numeros[0];
        pos = 1;
        for (int x = 0; x < 10; x++)
        {
            if (numeros[x] >= max)
            {
                max = numeros[x];
                pos = x + 1;
            }
        }

        Console.WriteLine("El numero y su posicon es: " + max + " y " + pos);

    }


}
