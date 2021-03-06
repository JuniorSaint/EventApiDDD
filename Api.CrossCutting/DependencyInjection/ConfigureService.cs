using Api.Domain.Interfaces.Services;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ISpeakerService, SpeakerService>();
            serviceCollection.AddTransient<IEventService, EventService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<ILotService, LotService>();
            serviceCollection.AddTransient<IUpLoadService, UpLoadService>();
        }
    }
}
