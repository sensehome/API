using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SenseHome.DB.Mongo;

namespace SenseHome.Repositories.TemperatureHumidity
{
    public class TemperatureHumdityRepository : ITemperatureHumidityRepository
    {
        private readonly IMongoCollection<DomainModels.TemperatureHumidity> collection;

        public TemperatureHumdityRepository(MongoDBContext mongoDbContext)
        {
            collection = mongoDbContext.Database.GetCollection<DomainModels.TemperatureHumidity>("temperatureHumidities");
        }

        public Task<DomainModels.TemperatureHumidity> CreateAsync(DomainModels.TemperatureHumidity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DomainModels.TemperatureHumidity>> GetAllAsync()
        {
            var cursor = await collection.FindAsync(p => true);
            return cursor.ToList();
        }

        public IQueryable<DomainModels.TemperatureHumidity> GetAsQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<DomainModels.TemperatureHumidity> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<DomainModels.TemperatureHumidity> UpdateAsync(DomainModels.TemperatureHumidity entity)
        {
            throw new NotImplementedException();
        }
    }
}
