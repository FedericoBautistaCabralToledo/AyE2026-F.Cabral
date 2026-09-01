namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Ubicacion> historialUbicaciones = new Stack<Ubicacion>();

            Ubicacion PrimerUbicacion = new Ubicacion(6, -43, "Cueva");
            Ubicacion SegundaUbicacion = new Ubicacion(125, 864, "Desierto");
            Ubicacion TerceraUbicacion = new Ubicacion(333, -333, "Bosque");

            historialUbicaciones.Push(PrimerUbicacion);
            historialUbicaciones.Push(SegundaUbicacion);
            historialUbicaciones.Push(TerceraUbicacion);

            foreach (Ubicacion Recorrer in historialUbicaciones)
            {
                Console.WriteLine($"Coordenada X:  {Recorrer.X}  Coordenada Y:  {Recorrer.Y}  Zona:  {Recorrer.NombreZona}");
            }


           Ubicacion test = historialUbicaciones.Pop();

            Console.WriteLine($"Ubicacion Removida = Coordenada X:  {test.X}  Coordenada Y:  {test.Y}  Zona:  {test.NombreZona}");

            Ubicacion test2 = historialUbicaciones.Peek();

            Console.WriteLine($"Ubicacion Actual = Coordenada X:  {test2.X}  Coordenada Y:  {test2.Y}  Zona:  {test2.NombreZona}");

        }
    }
}
