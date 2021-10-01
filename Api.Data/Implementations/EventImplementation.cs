using System;
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
    }
}

