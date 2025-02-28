using Microsoft.EntityFrameworkCore;
using webapi.Infrastructure.Seeds;

namespace webapi.Infrastructure.Models
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options):base(options){}

        public DbSet<Tarea> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //base.OnModelCreating(builder);

            builder.Entity<Tarea>()
                .HasIndex(u => u.Codigo)
                .IsUnique();

            //builder.ApplyConfiguration(new ClientSeed());
        }
    }
}
