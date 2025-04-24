using System.Security.Cryptography.X509Certificates;

namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int numero, con = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (par(numero))
                con++;
        }
        Console.WriteLine("La cantidad de numeros pares es: " + con);
    }

    static bool par(int a)
    {
        if (a % 2 == 0)
            return true;
        else
            return false;
    }
}
