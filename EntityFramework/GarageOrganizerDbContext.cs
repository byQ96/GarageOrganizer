using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class GarageOrganizerDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }

        public GarageOrganizerDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Cars)
                .WithOne(c => c.Client)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
