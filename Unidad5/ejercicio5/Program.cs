namespace ejercicio5;
class Program
{
    static void Main(string[] args)
    {
        int numero, maxPar = 0, minImpar = 0;
        bool BP = false, BI = false;


        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                if (!BP)
                {
                    maxPar = numero;
                    BP = true;
                }
                else if (numero > maxPar)
                    maxPar = numero;

            if (numero % 2 != 0)
                if (!BI)
                {
                    minImpar = numero;
                    BI = true;
                }
                else if (numero < minImpar)
                    minImpar = numero;
        }

        Console.WriteLine("El maximo par es: " + maxPar);
        Console.WriteLine("El minimo impar es: " + minImpar);
    }
}
