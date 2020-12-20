using SenseHome.DB.Mongo;

namespace SenseHome.Repositories.TemperatureHumidity
{
    public class TemperatureHumdityRepository : BaseRepository<DomainModels.TemperatureHumidity>, ITemperatureHumidityRepository
    {
        public TemperatureHumdityRepository(MongoDBContext mongoDbContext)
        {
            collection = mongoDbContext.Database.GetCollection<DomainModels.TemperatureHumidity>("temperatureHumidities");
        }
    }
}
