using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Event;

namespace Api.Domain.Interfaces.Services
{
    public interface IEventService
    {
        Task<EventDto> Get(Guid id);
        Task<IEnumerable<EventDto>> GetAll();
        Task<bool> Delete(Guid id);
        Task<EventDto> Put(EventUpdateDto evento);
        Task<EventDto> Post(EventCreateDto evento);
    }
}