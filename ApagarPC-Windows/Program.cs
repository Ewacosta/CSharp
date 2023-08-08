using System;
using System.Diagnostics;

namespace ApagadoProgramado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de apagado con temporizador");
            Console.Write("Ingresa en cuantos minutos deseas que se apague la pc: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // convertir el tiempo en segundos
            int segundos = minutos * 60;

            Console.WriteLine($"¡ATENCION! el equipo se apagara en {minutos} minutos.");
            Console.WriteLine();

            // Iniciar Programa - temporizador
            var temporizador = new System.Threading.Timer(OffComputadora, null, segundos * 1000, System.Threading.Timeout.Infinite);

            Console.WriteLine("Presiona Enter para detener el temporizador...");
            Console.ReadLine();

            // Detener Programa - temporizador
            temporizador.Dispose();

            Console.WriteLine("Temporizador detenido.");
        
            
        }

        static void OffComputadora(object state)
        {
            // Ejecutar comando para apagar la computadora
            Process.Start("shutdown", "/s /f /t 0");
        }
    }
            
}
