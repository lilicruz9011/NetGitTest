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

        public Vehiculo(decimal velocidadMax, int numeroDePuertas)
        {
            VelocidadMax = velocidadMax;
            NumeroDePuertas = numeroDePuertas;
        }

    }
}
