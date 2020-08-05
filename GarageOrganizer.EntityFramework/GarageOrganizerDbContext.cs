using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework
{
    public class GarageOrganizerDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public GarageOrganizerDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Cars)
                .WithOne(c => c.Client)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .HasMany(v => v.Visits)
                .WithOne(c => c.Car)
                .IsRequired();

            modelBuilder.Entity<Visit>()
                .Property(e => e.Repairs)
                .HasConversion(
                    s => string.Join(',', s),
                    s => s.Split(',', StringSplitOptions.RemoveEmptyEntries)
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
