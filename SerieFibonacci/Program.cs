using System;

namespace SerieFibonacciOptimizada
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            int contador = 0;
            Console.Write("Serie de Fibonacci (hasta cerca de 50): ");

            while (a < 50)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                contador++;

                // Si nos acercamos a 50, detenemos el bucle
                if (contador >= 34)
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}