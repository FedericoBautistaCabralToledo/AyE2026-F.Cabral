using System;

namespace BaseDeDatos2
{
    public struct Punto2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Mostrar()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }

    public class PuntoDb
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
