namespace ejercicio3;
class Program
{
    static void Main(string[] args)
    {
        // char[] cadena = new char[100];
        // char LetraActual, LetraNueva;
        // int indice;


        // indice = 0;
        // Console.WriteLine("Ingrese un caracter para formar la frase: ");
        // cadena[indice] = char.Parse(Console.ReadLine());

        // while (cadena[indice] != '0' && indice < 100)
        // {
        //     indice++;
        //     Console.WriteLine("Ingrese un caracter para formar la frase: ");
        //     cadena[indice] = char.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("La cadena original es: ");
        // indice = 0;
        // while (cadena[indice] != '0' && indice < 100)
        // {
        //     Console.Write(cadena[indice]);
        //     indice++;
        // }

        // Console.WriteLine("\nIngrese la primer letra: ");
        // LetraActual = char.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese la segunda letra: ");
        // LetraNueva = char.Parse(Console.ReadLine());

        // indice = 0;
        // while (cadena[indice] != '0' && indice < 100)
        // {
        //     if (cadena[indice] == LetraActual)
        //         cadena[indice] = LetraNueva;
        //     indice++;
        // }

        // Console.WriteLine("La cadena modificada es: ");
        // indice = 0;
        // while (cadena[indice] != '0' && indice < 100)
        // {
        //     Console.Write(cadena[indice]);
        //     indice++;
        // }

        string frase;
        char LetraActual, LetraNueva;

        Console.WriteLine("Ingrese una frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Ingrese la letra a reemplazar: ");
        LetraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la letra nueva");
        LetraNueva = char.Parse(Console.ReadLine());

        frase = frase.Replace(LetraActual, LetraNueva);
        Console.WriteLine("La frase modificada es: " + frase);
    }

}
