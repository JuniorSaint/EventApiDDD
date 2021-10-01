using Api.Data.Repository;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System;
using System.Linq;
using Api.Data.Contex;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(string email, string password)
        {
            try
            {
                return await _dataset.FirstOrDefaultAsync(u => u.Email.Equals(email) && u.Password.Equals(password) && u.IsActive.Equals(true));
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public async Task<UserEntity> GetByEmail(string email)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(u => u.Email.Equals(email));
            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserEntity>> SearchByEmail(string email)
        {
            try
            {
                var result = await _context.Users.Where(x => x.Email.ToLower().Contains(email.ToLower())).ToListAsync();
                return result;

            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserEntity>> SearchByName(string name)
        {
            try
            {
                var result = await _context.Users.Where(x => x.UserName.ToLower().Contains(name.ToLower())).ToListAsync();
                return result;
            }
            catch (ArgumentException)
            {
                throw;
            }
        }
    }
}