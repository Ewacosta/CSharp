﻿using System;

namespace ProductosIVA
{
 class Program
    {
        static void Main(string[] args)
        {
            //Incremento del IVA
            const double IVA = 0.13;
            int cantidadProducto = 10;
            double totalPagar = 0;

            for (int i = 1; i <= cantidadProducto; i++)
            {
                Console.WriteLine($"Ingresa los detalles del producto {i}: ");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio: ");
                double precio = double.Parse(Console.ReadLine());

                double subtotal = cantidad * precio;
                double impuesto = subtotal * IVA;
                double totalProducto = subtotal + impuesto;

                totalPagar += totalProducto;

                Console.WriteLine($"Subtotal: {subtotal:C}");
                Console.WriteLine($"Impuesto IVA: {impuesto:C}");
                Console.WriteLine($"Total a pagar: {totalProducto:c}");
                Console.WriteLine();
            }

            Console.WriteLine($"Total a pagar por los {cantidadProducto} productos: {totalPagar:c}");

        }
    }
}