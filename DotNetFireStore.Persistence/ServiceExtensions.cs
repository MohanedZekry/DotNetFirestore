using DotNetFireStore.Application.Repo.ICommon;
using DotNetFireStore.Domain.Entities;
using DotNetFireStore.Persistence.Context;
using DotNetFireStore.Persistence.Repo.Common;
using DotNetFireStore.Persistence.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFireStore.Persistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddSingleton<FirebaseDbContext>();

            services.AddScoped<IBaseRepository<User>>(provider =>
          new BaseRepository<User>(provider.GetRequiredService<FirebaseDbContext>(), Constants.GetCollectionName(CollectionNames.Users)));
            services.AddScoped<IBaseRepository<Group>>(provider =>
          new BaseRepository<Group>(provider.GetRequiredService<FirebaseDbContext>(),
                Constants.GetCollectionName(CollectionNames.Groups)));
        }
    }
}
