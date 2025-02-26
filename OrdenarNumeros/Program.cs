using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo para almacenar 10 números
        int[] numeros = new int[10];

        // Solicitar al usuario que ingrese 10 números
        Console.WriteLine("Por favor, ingrese 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Ordenar el arreglo utilizando el método Array.Sort
        Array.Sort(numeros);

        // Mostrar los números ordenados
        Console.WriteLine("\nNúmeros ordenados:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}