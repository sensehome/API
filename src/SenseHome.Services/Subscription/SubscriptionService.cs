using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SenseHome.Common.Exceptions;
using SenseHome.DataTransferObjects.Subscription;
using SenseHome.Repositories.Subscription;

namespace SenseHome.Services.Subscription
{
    public class SubscriptionService : BaseService, ISubscriptionService
    {
        private readonly ISubscriptionRepository subscriptionRepository;

        public SubscriptionService(IMapper mapper, ISubscriptionRepository subscriptionRepository) : base(mapper)
        {
            this.subscriptionRepository = subscriptionRepository;
        }

        public async Task<SubscriptionDto> AddSubscriptionAsync(SubscriptionInsertDto subscription)
        {
            var subscriptionToCreate = mapper.Map<DomainModels.Subscription>(subscription);
            var createdSubscription = await subscriptionRepository.CreateAsync(subscriptionToCreate);
            return mapper.Map<SubscriptionDto>(createdSubscription);
        }

        public async Task<bool> DeleteSubscriptionByIdAsync(string id)
        {
            var deleted = await subscriptionRepository.DeleteAsync(id);
            if(!deleted)
            {
                throw new BadRequestException("Failed to delete this entity");
            }
            return true;
        }

        public async Task<IEnumerable<SubscriptionDto>> GetUserSubscriptionsAsync(string userId)
        {
            var subscriptions = await subscriptionRepository.GetAllByUserIdAsync(userId);
            var subscriptionDtos = mapper.Map<IEnumerable<SubscriptionDto>>(subscriptions);
            return subscriptionDtos;
        }
    }
}
