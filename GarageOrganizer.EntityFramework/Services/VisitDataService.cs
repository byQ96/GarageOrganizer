using EntityFramework;
using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Threading.Tasks;

namespace GarageOrganizer.EntityFramework.Services
{
    public class VisitDataService
    {
        private readonly GarageOrganizerDbContextFactory _contextFactory;

        public VisitDataService(GarageOrganizerDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Visit> Create(Visit visit)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                await context.Visits.AddAsync(visit);
                await context.SaveChangesAsync();

                return visit;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var visit = await context.Visits.FirstOrDefaultAsync((v) => v.Id == id);
                context.Remove(visit);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<Visit> Get(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var visit = await context.Visits.FirstOrDefaultAsync((c) => c.Id == id);

                return visit;
            }
        }

        public async Task<IEnumerable> GetAll()
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var visits = await context.Visits.ToListAsync();

                return visits;
            }
        }

        public async Task<Visit> Update(int id, Visit visit)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                visit.Id = id;
                context.Update(visit);
                await context.SaveChangesAsync();

                return visit;
            }
        }
    }
}
