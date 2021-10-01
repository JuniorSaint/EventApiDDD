using System;
using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Contex
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }  // Configuração padrão

        protected override void OnModelCreating(ModelBuilder modelBuilder)   // Configuração padrão
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<EventEntity>(new EventMap().Configure);
            modelBuilder.Entity<LotEntity>(new LotMap().Configure);
            modelBuilder.Entity<SocialMediaEntity>(new SocialMediaMap().Configure);
            modelBuilder.Entity<SpeakerEntity>(new SpeakerMap().Configure);
            modelBuilder.Entity<EventSpeakerEntity>(new EventSpeakerMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData( //irá criar um usuário para acessar a aplicação
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    UserName = "Junior",
                    Email = "junior.saint@gmail.com",
                    Password = "123456",
                    IsActive = true,
                    UserType = "administrator",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }
    }
}

