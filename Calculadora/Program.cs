using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            // Mostrar el menú de la calculadora
            Console.WriteLine("Calculadora");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Elevar un número a la potencia");
            Console.WriteLine("6- Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            // Variables para almacenar los números
            double num1 = 0, num2 = 0, resultado = 0;

            // Solicitar los números si la opción no es salir
            if (opcion >= 1 && opcion <= 5)
            {
                Console.Write("Ingrese el primer número: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }

            // Realizar la operación seleccionada
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                case 5:
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"El resultado de elevar {num1} a la potencia {num2} es: {resultado}");
                    break;
                case 6:
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

            Console.WriteLine(); // Espacio para mejor legibilidad
        } while (opcion != 6); // Repetir hasta que el usuario seleccione salir
    }
}