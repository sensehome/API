using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SenseHome.DB.Mongo;

namespace SenseHome.Repositories.Subscription
{
    public class SubscriptionRepository : BaseRepository<DomainModels.Subscription>, ISubscriptionRepository
    {
        public SubscriptionRepository(MongoDBContext mongoDbContext)
        {
            collection = mongoDbContext.Database.GetCollection<DomainModels.Subscription>("subscriptions");
        }

        public async Task<IEnumerable<DomainModels.Subscription>> GetAllByUserIdAsync(string userId)
        {
            var cursor = await collection.FindAsync(s => s.UserId == userId);
            return cursor.ToList();
        }
    }
}
