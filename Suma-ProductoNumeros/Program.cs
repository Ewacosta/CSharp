using System;

namespace SumaProductoNumeros 
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiene que ingresar cuatro numeros. ");
            Console.WriteLine("OJO! los primeros dos numeros se sumaran y los otros dos numeros se obtendra el producto. ");

            Console.WriteLine("Ingrese el primer numero: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrse el segundo numero: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            double numero3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrse su cuarto numero: ");
            double numero4 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2;
            double producto = numero3 * numero4;

            Console.WriteLine($"El resultado de la suma de los dos primeros numeros es: {suma}");
            Console.WriteLine($"El producto (multiplicacion) del tercer y cuarto numero es: {producto}");
        }
    }
}