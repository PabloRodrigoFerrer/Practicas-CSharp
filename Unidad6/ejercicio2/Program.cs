using System.ComponentModel.DataAnnotations;

namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int numero, posicionGrupo = 0, contOrdenados = 0, min;
        float porcentajeMaximo = 0f, porcentajeImpares = 0f;


        for (int x = 0; x < 5; x++)
        {
            float contGeneral = 0f;
            float contImpar = 0f;
            bool banOrdenados = true;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            min = numero;

            while (numero != 0)
            {
                contGeneral++;
                if (numero % 2 != 0)
                    contImpar++;

                if (numero <= min)
                    min = numero;
                else
                    banOrdenados = false;


                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            porcentajeImpares = contImpar / contGeneral * 100f;

            if (porcentajeImpares > porcentajeMaximo)
            {
                porcentajeMaximo = porcentajeImpares;
                posicionGrupo = x + 1;
            }

            if (banOrdenados && contGeneral > 1)
                contOrdenados++;

        }

        Console.WriteLine("El numero de grupo con mayor porcentaje es: " + posicionGrupo + " con " + porcentajeMaximo + " %");
        Console.WriteLine("La cantidad de grupos ordenados es de: " + contOrdenados);

    }

}
