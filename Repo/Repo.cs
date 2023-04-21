using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;
using Models;

namespace Project.Data{
    public class AlmoxarifadoContext : DbContext{
        public DbSet<Models.Almoxarifado> almoxarifado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            var connectionString = "server=localhost;database=csharpalmoxarifadomanager;user=root;password=Wheniparkmyrr_1234";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}