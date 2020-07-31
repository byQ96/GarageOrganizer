using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class GarageOrganizerDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Cars)
                .WithOne(c => c.Client)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GarageOrganizerDb;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
