using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Event;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;

namespace Api.Service.Services
{
    public class EventService : IEventService
    {
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EventDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EventDto> Post(EventCreateDto evento)
        {
            throw new NotImplementedException();
        }

        public Task<EventDto> Put(EventUpdateDto evento)
        {
            throw new NotImplementedException();
        }
    }
}

