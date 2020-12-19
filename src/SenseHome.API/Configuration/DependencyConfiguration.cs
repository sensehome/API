﻿using Microsoft.Extensions.DependencyInjection;
using SenseHome.Repositories.User;
using SenseHome.Services.Authentication;
using SenseHome.Services.User;
using SenseHome.Services.UserExtension;

namespace SenseHome.API.Configuration
{
    public static class DependencyConfiguration
    {
        public static void AddDependentServicesAndRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserExtensionService, UserExtensionService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
        }
    }
}
