namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        int numero = 1, pos = 0;

        while (numero >= 0)
        {
            int contLista = 0;
            Console.WriteLine("Ingrese un numero positivo, 0 para cortar");
            numero = int.Parse(Console.ReadLine());
            pos++;

            while (numero > 0)
            {
                contLista++;
                Console.WriteLine("Ingrese un numero positivo, 0 para cortar");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La cantidad de numeros del grupo " + pos + " es: " + contLista);

        }
    }
}
