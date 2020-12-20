﻿using Microsoft.Extensions.DependencyInjection;
using SenseHome.Repositories.TemperatureHumidity;
using SenseHome.Repositories.User;
using SenseHome.Services.Authentication;
using SenseHome.Services.TemperatureHumidity;
using SenseHome.Services.User;
using SenseHome.Services.UserExtension;

namespace SenseHome.API.Configuration
{
    public static class DependencyConfiguration
    {
        public static void AddDependentServicesAndRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IUserExtensionService, UserExtensionService>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();

            services.AddSingleton<ITemperatureHumidityRepository, TemperatureHumdityRepository>();
            services.AddSingleton<ITemperatureHumidityService, TemperatureHumidityService>();
        }
    }
}
