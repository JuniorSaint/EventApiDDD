using System;
using Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Contex
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }  // Configuração padrão

        public DbSet<EventModel> Events { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)   // Configuração padrão
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<UserModel>().HasData( //irá criar um usuário para acessar a aplicação
            //    new UserModel
            //    {
            //        Id = Guid.NewGuid(),
            //        UserName = "Junior",
            //        Email = "junior.saint@gmail.com",
            //        Password = "123456",
            //        IsActive = true,
            //        UserType = "administrator",
            //        CreatedAt = DateTime.Now,
            //        UpdatedAt = DateTime.Now,
            //    });
        }
    }
}

