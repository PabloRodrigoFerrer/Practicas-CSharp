namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[10];
        int acu = 0, promedio, con = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numeros[x] = int.Parse(Console.ReadLine());
        }

        for (int x = 0; x < 10; x++)
        {
            acu += numeros[x];
            con++;
        }
        promedio = acu / con;

        Console.WriteLine("El promedio es: " + promedio);
        Console.Write("Los numeros mayores son: ");
        for (int x = 0; x < 10; x++)
        {
            if (numeros[x] > promedio)
                Console.Write(" " + numeros[x]);
        }


    }

}
