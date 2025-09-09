using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OpenStreetMaps
{
    public class OsmMapa:IMapa
    {
        public void Dibujar(string s) => Console.WriteLine("OSM mostrando: Peru, Lima");
    }
}
