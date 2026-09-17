using System.Security.Permissions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EjercicioBaseDeDatos
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            var LoQueVoyAInsertar = new Punto2D(2, 4);


            void Mostrar()
            {
                Console.WriteLine(LoQueVoyAInsertar);
            }
            Mostrar();

            string SQL = "CREATE DATABASE tp_bdd; USE tp_bdd; CREATE TABLE Puntos( id int PRIMARY KEY AUTO_INCREMENT, int X, int Y); ";


            db.Punto2D.Add(LoQueVoyAInsertar);
            db.SaveChanges();

            int id = 3;
            var datoBuscado = LoQueVoyAInsertar;
            datoBuscado = await db.Punto2D.FindAsync(id);


            if (datoBuscado != null)
            {
                int XUsuario = Console.ReadLine();
                int YUsuario = Console.ReadLine();
                datoBuscado.X = XUsuario;
                datoBuscado.Y = YUsuario;

            }
            int id2 = 1;
            var datoBuscado2 = 1;
            datoBuscado2 = await db.Punto2D.FindAsync(id);

            if (datoBuscado != null)
            {
                db.Punto2D.Remove(datoBuscado);
                await db.SaveChangesAsync();
            }

        }
    }
}
