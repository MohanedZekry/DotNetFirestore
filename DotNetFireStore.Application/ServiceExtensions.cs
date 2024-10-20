using DotNetFireStore.Application.IService.IUserService;
using DotNetFireStore.Application.Service.UserRepository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFireStore.Application
{
    public static class ServiceExtensions
    {
        public static void ConfigureApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
