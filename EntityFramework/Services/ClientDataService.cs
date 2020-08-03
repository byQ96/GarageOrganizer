using EntityFramework;
using GarageOrganizer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GarageOrganizer.EntityFramework.Services
{
    public class ClientDataService
    {
        private readonly GarageOrganizerDbContextFactory _contextFactory;

        public ClientDataService(GarageOrganizerDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<Client> Create(Client client)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                await context.Clients.AddAsync(client);
                await context.SaveChangesAsync();

                return client;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var client = await context.Clients.FirstOrDefaultAsync((c) => c.Id == id);
                context.Remove(client);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<Client> Get(int id)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var client = await context.Clients.FirstOrDefaultAsync((c) => c.Id == id);

                return client;
            }
        }

        public async Task<IEnumerable> GetAll()
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                var clients = await context.Clients.ToListAsync();

                return clients;
            }
        }

        public async Task<Client> Update(int id, Client client)
        {
            using (GarageOrganizerDbContext context = _contextFactory.CreateDbContext())
            {
                client.Id = id;
                context.Update(client);
                await context.SaveChangesAsync();

                return client;
            }
        }
    }
}
