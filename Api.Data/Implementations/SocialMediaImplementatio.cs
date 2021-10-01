using System;
using Api.Data.Contex;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class SocialMediaImplementatio : BaseRepository<SocialMediaEntity>, ISocialMediaRepository
    {
        private DbSet<SocialMediaEntity> _dataset;

        public SocialMediaImplementatio(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<SocialMediaEntity>();
        }
    }
}

