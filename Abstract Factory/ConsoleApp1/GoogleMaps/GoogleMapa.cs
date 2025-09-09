using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GoogleMapa:IMapa
    {
        public void Dibujar(string ubicacion) => Console.WriteLine("GoogleMaps mostrando: Argentina, Mar del Plata");
    }
}
