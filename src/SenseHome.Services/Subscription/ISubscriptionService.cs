using System.Threading.Tasks;
using SenseHome.DataTransferObjects.Subscription;

namespace SenseHome.Services.Subscription
{
    public interface ISubscriptionService
    {
        Task<SubscriptionDto> AddSubscriptionAsync(SubscriptionInsertDto subscription);
        Task<SubscriptionDto> UpdateSubscriptionAsync(SubscriptionDto subscription);
        Task<bool> DeleteSubscriptionByIdAsync(string id);
        Task<SubscriptionDto> GetUserSubscriptionsAsync(string userId);
    }
}
