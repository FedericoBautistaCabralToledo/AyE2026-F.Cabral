using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Evaluacion_Structs_Y_Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DañoGolpe = 20;

            Stack<Personaje> HistorialDelPersonaje = new Stack<Personaje>();


            Personaje Historial1 = new Personaje (100, 84, "Correr");
            HistorialDelPersonaje.Push(Historial1);

            Personaje Historial2 = new Personaje (100, 85, "Curar");
            HistorialDelPersonaje.Push(Historial2);

            Personaje Historial3 = new Personaje (100, 95, "Bailar");
            HistorialDelPersonaje.Push(Historial3);



            foreach (Personaje Recorrer in HistorialDelPersonaje)
            {
                Console.WriteLine($"VidaActual: {Recorrer.VidaActual} VidaTotal: {Recorrer.VidaTotal} Ultima Accion: {Recorrer.UltimaAccion}");
            }


            Personaje VolverEnElTiempo = HistorialDelPersonaje.Pop();
            Console.WriteLine($"Ultima Accion Borrada: {VolverEnElTiempo.UltimaAccion}");


            Personaje HistorialDaño = new Personaje(100, (VolverEnElTiempo.VidaActual - DañoGolpe), "Golpe Recibido");
            HistorialDelPersonaje.Push(HistorialDaño);

            foreach (Personaje Recorrer2 in HistorialDelPersonaje)
            {
                Console.WriteLine($"VidaActual: {Recorrer2.VidaActual} VidaTotal: {Recorrer2.VidaTotal} Ultima Accion: {Recorrer2.UltimaAccion}");
            }


        }
    }
}
