using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 0;

            Console.Write("Ingrese un número entero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Validamos que el número sea mayor a 1
            if (numero <= 1)
            {
                Console.WriteLine("El número debe ser mayor que 1.");
            }
            else
            {
                // Iteramos desde 2 hasta la raíz cuadrada del número
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                        break; // Si encontramos un divisor, el número no es primo
                    }
                }

                // Si el contador es 0, el número es primo
                if (contador == 0)
                {
                    Console.WriteLine(numero + " es un número primo.");
                }
                else
                {
                    Console.WriteLine(numero + " no es un número primo.");
                }
            }

            Console.ReadKey();
        }
    }
}