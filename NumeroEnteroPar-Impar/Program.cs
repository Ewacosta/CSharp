using System;

namespace EnteroParImpar{

    class program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Ingrese un numero entero");
            double numeroEntero = double.Parse(Console.ReadLine());

            if (numeroEntero % 2 == 0) 
            {
                Console.WriteLine($"el numero {numeroEntero} es par");
            }
            else
            {
                Console.WriteLine($"el numero {numeroEntero} es impar");
            }
            
        }
    }
}