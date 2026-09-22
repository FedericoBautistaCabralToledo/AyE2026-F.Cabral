using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BaseDeDatos2
{
    internal class AppDbContext : DbContext
    {
        public DbSet<PuntoDb> puntos => Set<PuntoDb>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = "Server=localhost;Port=3307;Database=puntos_db;Uid=root;pwd=;";
            var serverVersion = ServerVersion.AutoDetect(ConnectionString);
            optionsBuilder.UseMySql(ConnectionString, serverVersion);
        }
    }
}
