using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct Ubicacion
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string NombreZona { get; set; }

    public Ubicacion(int X, int Y, string NombreZona)
    {
            this.X = X;
            this.Y = Y;
            this.NombreZona = NombreZona;
    }

    }
}