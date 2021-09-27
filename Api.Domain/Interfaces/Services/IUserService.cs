using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;

namespace Api.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserDto> Post(UserCreateDto usuario);
        Task<UserDto> Put(UserUpdateDto usuario);
        Task<bool> Delete(Guid id);
        Task<UserDto> Get(Guid id);
        Task<IEnumerable<UserDto>> GetAll();
    }
}

