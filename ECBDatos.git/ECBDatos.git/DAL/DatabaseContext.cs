using ECBDatos.git.DAL.Entities;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace ECBDatos.git.DAL
{
    public class DatabaseContext:DbContext//lo que haga aca se ve reflejado en la BD y aca le doy contexto a la BD
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)//constructor obligatorio y eso solo se copia y pega
        {
            
        }

        public DbSet<Country>Countries { get; set; } //es el mapeo de las entidades y cada que cree una entidad debe hacer un DbSet y Countries es el nombre de la vble y en plural
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
