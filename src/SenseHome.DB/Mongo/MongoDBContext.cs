using MongoDB.Driver;

namespace SenseHome.DB.Mongo
{
    public class MongoDBContext
    {
        public IMongoDatabase Database;
     
        public MongoDBContext(MongoDBSettings settings)
        {
            IMongoClient client = new MongoClient(settings.Host);
            Database = client.GetDatabase(settings.Name);
        }
    }
}
