using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Lot;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class LotService : ILotService
    {

        private ILotRepository _repository;
        private readonly IMapper _mapper;

        public LotService(ILotRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid eventId, Guid id)
        {
            return await _repository.DeleteAsync(eventId, id);
        }

        public async Task<LotDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<LotDto>(entity);
        }

        public async Task<IEnumerable<LotDto>> GetLotByEventAsync(Guid idEvent)
        {
            var listEntity = await _repository.GetLotByEventAsync(idEvent);
            return _mapper.Map<IEnumerable<LotDto>>(listEntity);
        }

        public Task<LotDto> GetLotByEventLot(Guid eventId, Guid loteId)
        {
            throw new NotImplementedException();
        }

        public async Task<LotDto> Post(LotCreateDto lote)
        {
            var model = _mapper.Map<LotModel>(lote);
            var entity = _mapper.Map<LotEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<LotDto>(result);
        }

        public async Task<IEnumerable<LotDto>> Put(Guid idEvent, LotUpdateDto[] lotes)
        {
            var model = _mapper.Map<LotModel>(lotes);
            var entity = _mapper.Map<LotEntity>(model);
            var result = await _repository.UpdateLotAsync(idEvent, entity);
            return _mapper.Map<IEnumerable<LotDto>>(result);
        }

        public async Task<IEnumerable<LotDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<LotDto>>(listEntity);
        }

        public async Task<IEnumerable<LotDto>> GetAllLotCompleteAsync()
        {
            var listEntity = await _repository.GetAllLotCompleteAsync();
            return _mapper.Map<IEnumerable<LotDto>>(listEntity);
        }

        public Task<IEnumerable<LotDto>> GetLotByEvent(Guid idEvent)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LotDto>> GetAllComplete()
        {
            throw new NotImplementedException();
        }
    }
}

