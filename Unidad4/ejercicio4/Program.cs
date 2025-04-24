namespace ejercicio4;
class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3;
        int suma, producto;

        Console.WriteLine("Ingrese el primer numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero: ");
        n3 = int.Parse(Console.ReadLine());

        suma = n1 + n2;
        producto = n2 * n3;

        if (suma > producto)
            Console.WriteLine("La suma del primer numero con el segundo es: " + suma + " ,el producto del segundo con el tercero es: " + producto + " ,por ende la suma es mayor.");
        else
            Console.WriteLine("La suma del primer numero con el segundo es: " + suma + " ,el producto del segundo con el tercero es: " + producto + " ,por ende el producto es mayor.");

    }
}
