using System;

namespace EcuacionesCuadraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolvamos ecuacion cuadratica ax^2 + b^2 + c = 0 ");
            Console.WriteLine();

            Console.Write("Ingrese el valor de a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor de b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrse el valor de c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double discriminante = b * b - 4 * a * c;

            if (discriminante < 0)
            {
                Console.WriteLine("No tiene solucion reales.");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($" unica solucion es x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Las soluciones son x1 = {x1} y x2 = {x2}");
            }
            
        }
    }
}