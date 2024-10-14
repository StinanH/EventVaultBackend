﻿using EventVault.Data.Repositories.IRepositories;
using EventVault.Models;

namespace EventVault.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly EventVaultDbContext _context;

        public EventRepository(EventVaultDbContext context) {

            _context = context;
        
        }

        public async Task<IEnumerable<Event>> GetEventsAsync(int userId)
        {
            //
            var eventsList = new List<Event>();

            return eventsList;
        }

    }
}
