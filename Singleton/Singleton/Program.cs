using Singleton.Clases;
using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Logger.Instancia;
            a.Info("Aplicación iniciada");
            a.Info("Conectando a la base de datos");

           
            var b = Logger.Instancia;
            b.Info("Proceso completado correctamente");

            
            b.Dump();

            
            Console.WriteLine($"¿Misma instancia? {ReferenceEquals(a, b)}");
        }
    }
}
