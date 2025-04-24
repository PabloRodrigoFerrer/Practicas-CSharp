namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4;

        Console.WriteLine("Ingrese el primer numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero: ");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el cuarto numero: ");
        n4 = int.Parse(Console.ReadLine());


        if ((n1 > n2) && (n2 > n3) && (n3 > n4))
            Console.WriteLine("Ordenados decrecientemente.");
        else
            Console.WriteLine("No ordenados");

    }
}
