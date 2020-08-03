using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageOrganizer.EntityFramework
{
    public class GarageOrganizerDbContextFactory : IDesignTimeDbContextFactory<GarageOrganizerDbContext>
    {
        public GarageOrganizerDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<GarageOrganizerDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GarageOrganizerDb;Trusted_Connection=True;");

            return new GarageOrganizerDbContext(options.Options);
        }
    }
}
