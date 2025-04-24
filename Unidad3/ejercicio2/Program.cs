namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int numero;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero > 0)
            Console.WriteLine("Positivo");
        else if (numero < 0)
            Console.WriteLine("Negativo");
        else
            Console.WriteLine("Cero");


    }
}
