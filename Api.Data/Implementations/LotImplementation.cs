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
    }
}

