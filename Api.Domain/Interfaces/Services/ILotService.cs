using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Lot;

namespace Api.Domain.Interfaces.Services
{
    public interface ILotService
    {
        Task<LotDto> Post(LotCreateDto lote);
        Task<LotDto> Put(Guid idEvent, LotUpdateDto[] lote);
        Task<bool> Delete(Guid id);
        Task<IEnumerable<LotDto>> GetAll();
        Task<IEnumerable<LotDto>> GetLotByEvent(Guid idEvent);
        Task<IEnumerable<LotDto>> GetLotByEventLot(Guid eventId, Guid loteId);
        Task<IEnumerable<LotDto>> GetAllComplete();
    }
}

