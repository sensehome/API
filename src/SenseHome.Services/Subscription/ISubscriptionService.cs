using System.Collections.Generic;
using System.Threading.Tasks;
using SenseHome.DataTransferObjects.Subscription;

namespace SenseHome.Services.Subscription
{
    public interface ISubscriptionService
    {
        Task<SubscriptionDto> AddSubscriptionAsync(SubscriptionInsertDto subscription);
        Task<bool> DeleteSubscriptionByIdAsync(string id);
        Task<IEnumerable<SubscriptionDto>> GetUserSubscriptionsAsync(string userId);
    }
}
