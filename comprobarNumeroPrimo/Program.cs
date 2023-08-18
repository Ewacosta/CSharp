using System;

namespace comprobarNumeroPrimo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            bool numeroPrimo = EsPrimo(numero);

            if (numeroPrimo)
            {
                Console.WriteLine($"El numero {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no es primo.");
            }
        }
        static bool EsPrimo(int comprobar)
        {
            if (comprobar <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt (comprobar); i++)
            {
                if (comprobar % 1 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
