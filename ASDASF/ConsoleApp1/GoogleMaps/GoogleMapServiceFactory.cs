using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.GoogleMaps
{
    public class GoogleMapServicesFactory : IMapServiceFactory
    {
        public IMapa CreateMapa()
        {
            return new GoogleMapa();
        }

        public IGeocoder CreateGeocoder()

        {
            return new GoogleGeocoder();
        }
    }
}
