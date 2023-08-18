using System;

namespace CompraArticulo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcularemos el total que pagara el cliente por la compra de articulos");
            Console.WriteLine();

            Console.WriteLine("Ingrese el precio que cuesta el articulo: ");
            double precioArticulo = double.Parse(Console.ReadLine());
            
            Console.WriteLine("ingrese la cantidad de articulos: ");
            double cantidadArticulo = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double totalPagar = precioArticulo * cantidadArticulo;

            Console.WriteLine($"Total a pagar es : {totalPagar:C}");
        }
    }
}
