using System;

namespace MultiplicacionNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, multiplicacion;

            Console.Write("Ingrese el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            multiplicacion = num1 * num2;

            Console.WriteLine("El resultado de la multiplicación es: {0}", multiplicacion);

            Console.ReadKey();
        }
    }
}