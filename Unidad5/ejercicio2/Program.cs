﻿namespace ejercicio2;
class Program
{
    static void Main(string[] args)
    {
        int numero, mayor = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (x == 0)
                mayor = numero;
            else if (numero > mayor)
                mayor = numero;
        }

        Console.WriteLine("El numero mayor es: " + mayor);
    }
}

