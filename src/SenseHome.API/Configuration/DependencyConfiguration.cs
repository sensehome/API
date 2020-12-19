using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SenseHome.API.Settings;
using SenseHome.Repositories.User;
using SenseHome.Services.User;

namespace SenseHome.API.Configuration
{
    public static class DependencyConfiguration
    {
        public static void AddDependentServicesAndRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
