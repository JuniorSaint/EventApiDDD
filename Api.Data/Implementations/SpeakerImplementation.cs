using System;
using Api.Data.Contex;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class SpeakerImplementation : BaseRepository<SpeakerEntity>, ISpeakerRepository

    {
        private DbSet<SpeakerEntity> _dataset;

        public SpeakerImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<SpeakerEntity>();
        }
    }
}

