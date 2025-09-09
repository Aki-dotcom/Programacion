using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OpenStreetMaps
{
    public class OsmGeocoder:IGeocoder
    {
        public void Buscar(string a) => Console.WriteLine("Coords OSM: -38.01, -57.54 para Chile");
    }
}
