using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;
using Api.Domain.Dtos.Event;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class EventService : IEventService
    {
        private IEventRepository _repository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<EventDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<EventDto>(entity);
        }

        public async Task<IEnumerable<EventDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<EventDto>>(listEntity);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<EventDto> Put(EventUpdateDto evento)
        {
            var model = _mapper.Map<EventModel>(evento);
            var entity = _mapper.Map<EventEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<EventDto>(result);
        }

        public async Task<EventDto> Post(EventCreateDto evento)
        {
            var model = _mapper.Map<EventModel>(evento);
            var entity = _mapper.Map<EventEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<EventDto>(result);
        }

        public async Task<EventDto> GetAllByTheme(string theme)
        {
            var entity = await _repository.GetAllEventByThemeAsync(theme);
            return _mapper.Map<EventDto>(entity);
        }

        public async Task<EventDto> GetEventById(Guid eventId)
        {
            var entity = await _repository.GetEventByIdAsync(eventId);
            return _mapper.Map<EventDto>(entity);
        }

        public async Task<EventDto> PostUpload(EventUpdateDto evento, Guid id)
        {
            var model = _mapper.Map<EventModel>(evento);
            var entity = _mapper.Map<EventEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<EventDto>(result);
        }

        public async Task<IEnumerable<EventDto>> GetAllPage(int skip, int take)
        {
            var listPage = await _repository.SelectAllPageAsync(skip, take);
            return _mapper.Map<IEnumerable<EventDto>>(listPage);
        }
    }
}

