using System.Threading.Channels;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ConsoleApp1
{
    internal class Program
    {
        //Crear

        new Valorant =
            {
            nombre_agente = "test";
            tipo_agente = "Iniciador";
            nacionalidad = "Romano";
            fecha_lanzamiento = "2020-06-01";
            }
            SaveChangesAsync();

        void OrdenamientoBurbujaAlfabeticamente()
        {
            for (int u = 0; u < Agentes.Count; u++)
            {
                Console.WriteLine(Agentes[u].nombre_agente);
            }
        }

    }
}
