using System.Collections.Generic;
using System.Threading.Tasks;

namespace SenseHome.Repositories.Subscription
{
    public interface ISubscriptionRepository : IBaseRepository<DomainModels.Subscription>
    {
        Task<IEnumerable<DomainModels.Subscription>> GetAllByUserIdAsync(string userId);
    }
}
