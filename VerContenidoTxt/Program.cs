using System;
using System.IO;

namespace VerContenidoTxt
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la ruta del archivo texto (.txt): ");
            string Archivo = Console.ReadLine();

            if ( File.Exists(Archivo) )
            {
                string[] lineas = File.ReadAllLines(Archivo);

                Console.WriteLine($"Contenido del archivo '{Archivo}': ");
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
                
            }
            else
            {
                Console.WriteLine("ruta proporcionada no valida, archivo no existe.");
            }
        }   
    }
}