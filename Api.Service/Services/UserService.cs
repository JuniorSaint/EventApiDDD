using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Repositories;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {

        private IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UserDto>(entity);
        }

        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDto>>(listEntity);
        }

        public async Task<UserDto> Post(UserCreateDto user)
        {
            var passwordHasher = new PasswordHasher<UserCreateDto>();
            user.Password = passwordHasher.HashPassword(user, user.Password);

            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserDto>(result);
        }

        public async Task<UserUpdateResultDto> Put(UserUpdateDto user)
        {

            var passwordHasher = new PasswordHasher<UserUpdateDto>();
            user.Password = passwordHasher.HashPassword(user, user.Password);

            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);

            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UserUpdateResultDto>(result);
        }

        async Task<IEnumerable<UserDto>> IUserService.GetAllPage(int skip, int take)
        {
            var listPage = await _repository.SelectAllPageAsync(skip, take);
            return _mapper.Map<IEnumerable<UserDto>>(listPage);
        }
    }
}
