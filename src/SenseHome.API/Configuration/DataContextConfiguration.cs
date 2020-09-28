using Microsoft.Extensions.DependencyInjection;
using SenseHome.DB.Mongo;

namespace SenseHome.API.Configuration
{
    public static class DataContextConfiguration
    {
        public static void AddDataContext(this IServiceCollection services)
        {
            services.AddSingleton<MongoDBSettings>();
            services.AddSingleton<MongoDBContext>();
        }
    }
}
