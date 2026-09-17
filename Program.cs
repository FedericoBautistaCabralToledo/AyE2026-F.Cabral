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

            db.Punto2D.Add(LoQueVoyAInsertar);
            db.SaveChanges();

            void Mostrar()
            {
                Console.WriteLine(LoQueVoyAInsertar);
            }
            Mostrar();
        }
    }
}
