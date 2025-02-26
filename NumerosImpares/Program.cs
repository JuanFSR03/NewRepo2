using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números impares del 1 al 30:");

            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}