using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EjercicioBaseDeDatos
{
    internal class AppDbContext : DbContext  
    {
        public DbSet<Punto2D> Punto2D => Set<Punto2D>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {

            string ConnectionString = "Server=localhost;Port=3307;Database == tp_bdd;Uid=root;pwd=;"; 
            var serverVersion = ServerVersion.AutoDetect(ConnectionString); 
            optionsBuilder.UseMySql(ConnectionString, serverVersion);
        }

    }
}