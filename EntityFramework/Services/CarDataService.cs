using EntityFramework;
using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace GarageOrganizer.EntityFramework.Services
{
    public class CarDataService
    {
        private readonly GarageOrganizerDbContextFactory _contextFactory;

        public CarDataService(GarageOrganizerDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Car> Create(Car car)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                await context.Cars.AddAsync(car);
                await context.SaveChangesAsync();

                return car;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var car = await context.Cars.FirstOrDefaultAsync((c) => c.Id == id);
                context.Remove(car);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<Car> Get(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var car = await context.Cars.FirstOrDefaultAsync((c) => c.Id == id);

                return car;
            }
        }

        public async Task<IEnumerable> GetAll()
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var cars = await context.Cars.ToListAsync();

                return cars;
            }
        }

        public async Task<Car> Update(int id, Car car)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                car.Id = id;
                context.Update(car);
                await context.SaveChangesAsync();

                return car;
            }
        }
    }
}
