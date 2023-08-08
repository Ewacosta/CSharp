using System;

namespace Planilla
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos de empleados
            string[] Nombre = new string[5];
            string[] dui = new string[5];
            string[] nit = new string[5];
            double[] salarioPorHora = new double[5];
            double[] horasTrabajadas = new double[5];
            double totalPlanilla = 0;

            //Registro de empleados
            for (int i = 0; i < 2 ; i++)
            {
                Console.WriteLine($"ID Empleado {i + 1}");
                Console.Write("Nombre: ");
                Nombre[i] = Console.ReadLine();

                Console.Write("DUI: ");
                dui[i] = Console.ReadLine();

                Console.Write("NIT: ");
                nit[i] = Console.ReadLine();

                Console.Write("Salario/hora: ");
                salarioPorHora[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Horas trabajadas: ");
                horasTrabajadas[i]  = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();                
            }                    

            Console.WriteLine("Listado de empleados:");
            Console.WriteLine("ID\tNombre\t\tHorasTrabajadas\t\tSalario/Hora\tSalario\t\tRenta\t\tTotal");
                
            for (int i = 0; i < 2; i++)
            {
                double salarioTotal = salarioPorHora[i] * horasTrabajadas[i];
                totalPlanilla += salarioTotal;
                double renta = salarioTotal * 0.10;
                double pagoNeto = salarioTotal - renta;


                Console.WriteLine($"{i + 1}\t{Nombre[i]}\t\t{horasTrabajadas[i]}\t\t{salarioPorHora[i]:C}\t\t{salarioTotal:C}\t\t{renta}\t\t{pagoNeto}");
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            Console.WriteLine($"Total de la planilla:\t{totalPlanilla:C}");

            Console.ReadLine();

        }
    }
}
