using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repositories
{
    public interface ILotRepository : IRepository<LotEntity>
    {
        Task<IEnumerable<LotEntity>> GetAllLotCompleteAsync();
        Task<IEnumerable<LotEntity>> GetLotByEventAsync(Guid idEvent);
        Task<IEnumerable<LotEntity>> UpdateLotAsync(Guid idEvent, LotEntity[] items);
    }
}

