namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 10)
            Console.WriteLine("Mayor a 10");
        else
            Console.WriteLine("Menor a 10");

    }
}
