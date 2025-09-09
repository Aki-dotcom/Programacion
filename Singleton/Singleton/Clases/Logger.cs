using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Clases
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instancia = new(() => new Logger());
        public static Logger Instancia => _instancia.Value;

        private readonly List<string> _historial = new();

        private Logger() { }

        public void Info(string mensaje)
        {
            var log = $"[INFO] {DateTime.Now:HH:mm:ss} - {mensaje}";
            _historial.Add(log);
            Console.WriteLine(log);
        }

        public void Dump()
        {
            Console.WriteLine("=== HISTORIAL DE LOGS ===");
            foreach (var msg in _historial)
                Console.WriteLine(msg);
        }
    }
}
