using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.SocialMedia;

namespace Api.Domain.Interfaces.Services
{
    public interface ISocialMediaService
    {
        Task<SocialMediaDto> Get(Guid id);
        Task<IEnumerable<SocialMediaDto>> GetAll();
        Task<bool> Delete(Guid id);
        Task<SocialMediaDto> Put(SocialMediaCreateDto social);
        Task<SocialMediaDto> Post(SocialMediaUpdateDto social);
    }
}

