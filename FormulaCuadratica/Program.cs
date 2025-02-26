using System;

namespace FormulaCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminante, x1, x2;

            Console.Write("Ingrese el valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            // Calculamos el discriminante
            discriminante = b * b - 4 * a * c;

            // Verificamos si hay soluciones reales
            if (discriminante >= 0)
            {
                // Calculamos las raíces
                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                Console.WriteLine("Las soluciones son:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }

            Console.ReadKey();
        }
    }
}