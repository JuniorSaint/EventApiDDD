using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Speaker;

namespace Api.Domain.Interfaces.Services
{
    public interface ISpeakerService
    {
        Task<SpeakerDto> Post(SpeakerCreateDto palestrante);
        Task<SpeakerDto> Put(SpeakerUpdateDto palestrante);
        Task<bool> Delete(Guid id);
        Task<SpeakerDto> Get(Guid id);
        Task<IEnumerable<SpeakerDto>> GetAll();
    }
}

