using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Speaker;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class SpeakerService : ISpeakerService
    {
        private ISpeakerRepository _repository;
        private readonly IMapper _mapper;

        public SpeakerService(ISpeakerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<SpeakerDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<SpeakerDto>(entity);
        }

        public async Task<IEnumerable<SpeakerDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<SpeakerDto>>(listEntity);
        }

        public async Task<SpeakerDto> Post(SpeakerCreateDto palestrante)
        {
            var model = _mapper.Map<SpeakerModel>(palestrante);
            var entity = _mapper.Map<SpeakerEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<SpeakerDto>(result);
        }

        public async Task<SpeakerDto> Put(SpeakerUpdateDto palestrante)
        {
            var model = _mapper.Map<SpeakerModel>(palestrante);
            var entity = _mapper.Map<SpeakerEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<SpeakerDto>(result);
        }

        public async Task<IEnumerable<SpeakerDto>> GetAllPage(int skip, int take)
        {
            var listPage = await _repository.SelectAllPageAsync(skip, take);
            return _mapper.Map<IEnumerable<SpeakerDto>>(listPage);
        }
    }
}

