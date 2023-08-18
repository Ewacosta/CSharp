using System;

namespace SumaNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa ayudara a sumar numeros pares en un rango de numeros.");
            Console.WriteLine();

            Console.Write("Ingrese el valor mínimo del rango: ");
            int minimo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor máximo del rango: ");
            int maximo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cuantos numeros pares necesita sumar dentro del rango establecido: ");
            int n = int.Parse(Console.ReadLine());

            int sumaP = SumaParesEnRango(minimo, maximo, n);
            Console.WriteLine($"La suma de los primeros {n} números pares en el rango {minimo} a {maximo} es: {sumaP}");
        }

        static int SumaParesEnRango( int min, int max, int n)
        {
            int suma = 0;
            int contador = 0;

            for (int num = min; num <= max && contador < n; num++)
            {
                if (num % 2 == 0)
                {
                    suma += num;
                    contador++;
                }
            }

            return suma;
        }
    }
}
