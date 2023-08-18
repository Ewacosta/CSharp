using System;
using System.Collections.Generic;

namespace InstruccioForeach
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> autos = new List<string> { "Toyota", "Hyundai", "Nissan", "KIA" };

            Console.WriteLine("Lista de Autos: ");

            int id = 1;

            foreach (string auto in autos)
            { 
                Console.WriteLine($"{id} {auto}");
                id++;
            
            }
        }
    }
}
