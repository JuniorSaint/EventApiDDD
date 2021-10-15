using Api.Data.Repository;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System;
using System.Linq;
using Api.Data.Contex;
using Api.Domain.Dtos.User;
using Api.Domain.Dtos.Login;
using Microsoft.AspNetCore.Identity;

namespace Api.Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataset;

        public UserImplementation(MyContext contex) : base(contex)
        {
            _dataset = contex.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLoginAsync(LoginDto login)
        {
            try
            {
                var result = await _dataset.FirstOrDefaultAsync(
                         u => u.Email.Equals(login.Email) &&
                          u.IsActive.Equals("yes"));

                if (result == null)
                {
                    return null;
                }
                var validResult = await ValidUpdatePassword(login, result.Password);
                return validResult ? result : null;

            }
            catch (ArgumentException)
            {
                throw;
            }
        }

        // to valid the password cripytography
        private async Task<bool> ValidUpdatePassword(LoginDto login, string resultPassword)
        {
            var passwordHasher = new PasswordHasher<LoginDto>();
            var status = passwordHasher.VerifyHashedPassword(login, resultPassword, login.Password);
            switch (status)
            {
                case PasswordVerificationResult.Failed: return false;
                case PasswordVerificationResult.Success: return true;
                case PasswordVerificationResult.SuccessRehashNeeded:
                    await UpdatePasswordAsync(login); return true;
                default: throw new InvalidOperationException();
            }
        }

        public async Task<UserEntity> GetByEmailAsync(string email)
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

        public async Task<IEnumerable<UserEntity>> SearchByEmailAsync(string email)
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

        public async Task<IEnumerable<UserEntity>> SearchByNameAsync(string name)
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

        public async Task<bool> UpdatePasswordAsync(LoginDto password)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Email.Equals(password.Email));
                if (result == null) return false;

                password.UpdatedAt = DateTime.UtcNow;
                password.CreatedAt = result.CreatedAt;

                _context.Entry(result).CurrentValues.SetValues(password);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

    }
}