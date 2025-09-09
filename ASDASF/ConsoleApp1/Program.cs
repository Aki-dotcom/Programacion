using System;
using ConsoleApp1.GoogleMaps;
using ConsoleApp1.OpenStreetMaps;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMapServiceFactory factory = new OsmMapServiceFactory();

            var app = new Navegador(factory);
            app.Run("Ubicacion","TextoDireccion");
        }
    }
}
