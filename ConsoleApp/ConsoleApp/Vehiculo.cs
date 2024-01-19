using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Vehiculo
    {
        public decimal VelocidadMax { get; set; }
        public int NumeroDePuertas { get; set; }
        public decimal PrecioVehiculo { get; set; }

        public Vehiculo(decimal velocidadMax, int numeroDePuertas, decimal precioVehiculo)
        {
            VelocidadMax = velocidadMax;
            NumeroDePuertas = numeroDePuertas;
            PrecioVehiculo = precioVehiculo;
        }

    }
}
