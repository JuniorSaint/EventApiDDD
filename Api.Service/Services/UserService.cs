using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Interfaces.Services;


namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Post(UserCreateDto usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> Put(UserUpdateDto usuario)
        {
            throw new NotImplementedException();
        }
    }
}
