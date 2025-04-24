namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        float importe, litros;

        Console.WriteLine("Ingrese el importe total: ");
        importe = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad de litros: ");
        litros = float.Parse(Console.ReadLine());

        if (litros > 500)
            importe *= 0.75f;
        else if (litros > 300)
            importe *= 0.85f;
        else if (litros > 100)
            importe *= 0.90f;

        Console.WriteLine("El total a abonar es: $" + importe);

    }
}
