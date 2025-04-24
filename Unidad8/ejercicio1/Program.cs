using System.Reflection.Metadata.Ecma335;

namespace ejercicio1;
class Program
{
    static void Main(string[] args)
    {
        int precio;
        int cantidad;
        int prod;

        Console.WriteLine("Ingrese el precio del articulo: ");
        precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida");
        cantidad = int.Parse(Console.ReadLine());

        prod = prodcuto(precio, cantidad);
        Console.WriteLine("El monto total a pagar es: " + prod);

    }

    static int prodcuto(int a, int b)
    {
        int resultado;
        resultado = a * b;

        return resultado;
    }
}