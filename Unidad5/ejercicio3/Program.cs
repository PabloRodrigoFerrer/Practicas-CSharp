namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        float edad, acu = 0, con = 0;
        float promedio;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                acu += edad;
                con++;
            }
        }

        promedio = acu / con;

        Console.WriteLine("Las edades promedio son: " + promedio);
    }
}

