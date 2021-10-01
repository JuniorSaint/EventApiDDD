using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email, string password); // Seleciona email e pass para poder logar 

        Task<UserEntity> GetByEmail(string email); //seleciona um email específico

        Task<IEnumerable<UserEntity>> SearchByEmail(string email); //seleciona  os emails que tem em trecho da procura

        Task<IEnumerable<UserEntity>> SearchByName(string name);


    }
}

