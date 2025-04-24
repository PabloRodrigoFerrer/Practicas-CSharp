namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int numero, contDivs = 0;

        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        for (int x = 1; x <= numero; x++)
        {
            if (numero % x == 0)
                contDivs++;
        }
        if (contDivs == 2)
            Console.WriteLine("El numero es primo");
        else
            Console.WriteLine("El numero no es primo");
    }
}
