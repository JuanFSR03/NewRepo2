using System;

namespace DivisionNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, division;

            Console.Write("ingrese primer numero:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese segundo numero:");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("No se puede dividir por cero, Por favor intente con otro numero distinto");
            }
            else
            {
                division = num1 / num2;
                Console.WriteLine("El resultado de la división es: {0}", division);
            }

            Console.ReadKey();
        }
    }
}