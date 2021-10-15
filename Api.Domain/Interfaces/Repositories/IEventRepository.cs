using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repositories
{
    public interface IEventRepository : IRepository<EventEntity>
    {
        Task<IEnumerable<EventEntity>> GetAllEventByThemeAsync(string theme);
        Task<EventEntity> GetEventByIdAsync(Guid eventId);

    }
}

