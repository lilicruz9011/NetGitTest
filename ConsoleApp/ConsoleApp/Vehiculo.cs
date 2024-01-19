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

        public Vehiculo(decimal velocidadMax) 
        {
            VelocidadMax = velocidadMax;
        }

    }
}
