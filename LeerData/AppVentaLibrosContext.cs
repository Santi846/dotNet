
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    public class AppVentaLibrosContext : DbContext
    {
        private const string connectionString = @"Data Source=NB-SANTI;Initial Catalog=LibrosWeb;Integrated Security=True";
        // private const string connectionString = @"Data Source=NB-SANTI\sqlexpress;Initial Catalog=LibrosWeb;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Libro>? Libro {get;set;}

        public DbSet<Precio>? Precio {get;set;}
    }
}
