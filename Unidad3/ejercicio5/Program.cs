using System.Timers;

namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, contador = 0;

        Console.Write("Ingrese el primer numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el cuarto numero: ");
        n4 = int.Parse(Console.ReadLine());

        if (n1 > 100)
        {
            Console.Write(n1 + ", ");
            contador++;
        }
        if (n2 > 100)
        {
            Console.Write(n2 + ", ");
            contador++;
        }
        if (n3 > 100)
        {
            Console.Write(n3 + ", ");
            contador++;
        }
        if (n4 > 100)
        {
            Console.Write(n4 + ", ");
            contador++;
        }

        if (contador != 0)
            Console.Write("son mayores a 100: " + contador + " numeros... ");

        Console.WriteLine("Fin del programa");

    }
}
