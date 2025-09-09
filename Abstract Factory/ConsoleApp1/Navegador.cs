using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class Navegador
    {
        private readonly IMapa _mapa;
        private readonly IGeocoder _geocoder;

        public Navegador(IMapServiceFactory factory)
        {
            _mapa = factory.CreateMapa();
            _geocoder = factory.CreateGeocoder();

        }

        public void Run(string ubicacion, string textoDireccion)
        {
            _mapa.Dibujar(ubicacion);
            _geocoder.Buscar(textoDireccion);
        }
    }
}
