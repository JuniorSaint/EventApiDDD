using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Repositories;
using Api.Data.Implementations;
using Api.Data.Contex;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {

        private static string Host = "localhost";
        private static string User = "Junior";
        private static string DBname = "EventDB";
        private static string Password = "123456";
        private static string Port = "5432";

        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<IEventRepository, EventImplementation>();
            serviceCollection.AddScoped<ILotRepository, LotImplementation>();
            serviceCollection.AddScoped<ISocialMediaRepository, SocialMediaImplementatio>();
            serviceCollection.AddScoped<ISpeakerRepository, SpeakerImplementation>();

            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseNpgsql($"Server={Host}; Port={Port}; Database={DBname}; Uid={User}; Pwd={Password}")
                 );
        }
    }
}
