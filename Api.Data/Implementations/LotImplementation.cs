using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Api.Data.Contex;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class LotImplementation : BaseRepository<LotEntity>, ILotRepository
    {
        private DbSet<LotEntity> _dataset;

        public LotImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<LotEntity>();
        }

        public async Task<IEnumerable<LotEntity>> GetAllLotCompleteAsync()
        {
            try
            {
                return await _dataset.Include(l => l.Event).ToListAsync();
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public async Task<IEnumerable<LotEntity>> GetLotByEventAsync(Guid idEvent)
        {
            try
            {
                return await _dataset.Where(x => x.EventId.Equals(idEvent)).ToListAsync();
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}

