using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Contex;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class EventImplementation : BaseRepository<EventEntity>, IEventRepository
    {
        private DbSet<EventEntity> _dataset;

        public EventImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EventEntity>();
        }

        public async Task<IEnumerable<EventEntity>> GetAllEventByThemeAsync(string theme)
        {
            try
            {
                return await _dataset.Where(x => x.Theme == theme).Include(x => x.EventSpeakers).ThenInclude(pe => pe.Speaker).ToListAsync();
            }
            catch (ArgumentException)
            {
                throw;
            }
        }


        public async Task<EventEntity> GetEventByIdAsync(Guid eventId)
        {
            try
            {
                return await _dataset.Include(x => x.EventSpeakers).ThenInclude(pe => pe.Speaker).FirstOrDefaultAsync(x => x.Id.Equals(eventId));
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}

