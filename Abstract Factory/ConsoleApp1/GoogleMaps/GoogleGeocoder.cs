﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GoogleGeocoder:IGeocoder
    {
        public void Buscar (string textoDireccion) => Console.WriteLine("Coords GM: -38.00, -57.55 para Argentina, Batan");
    }
}
