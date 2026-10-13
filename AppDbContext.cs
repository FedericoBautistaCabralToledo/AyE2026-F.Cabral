using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Valorant> Valorant => Set<Valorant>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=3307;Database=valorant;Uid=root;pwd=";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
