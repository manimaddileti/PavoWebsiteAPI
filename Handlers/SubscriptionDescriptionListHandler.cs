using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteDatabase.Handlers
{
    public class SubscriptionDescriptionListHandler
    {
        private readonly ISubscriptionDescriptionListRepository _subscriptionDescriptionListRepository;

        public SubscriptionDescriptionListHandler(ISubscriptionDescriptionListRepository subscriptionDescriptionListRepository)
        {
            _subscriptionDescriptionListRepository = subscriptionDescriptionListRepository;
        }
        public async Task<IEnumerable<SubscriptionDescriptionList>> GetSubscriptionDescriptionListAsync()
        {
            var subscriptionData = await _subscriptionDescriptionListRepository.GetSubscriptionDescriptionListAsync();
            if (subscriptionData == null || !subscriptionData.Any())
            {
                throw new Exception("subscription description list not found");
            }
            return subscriptionData;
        }
    }
}
