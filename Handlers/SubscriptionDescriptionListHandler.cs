using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteDatabase.Handlers
{
    public class SubscriptionDescriptionListHandler
    {
        private readonly SubscriptionDescriptionListRepository _subscriptionDescriptionListRepository;

        public SubscriptionDescriptionListHandler(SubscriptionDescriptionListRepository subscriptionDescriptionListRepository)
        {
            _subscriptionDescriptionListRepository = subscriptionDescriptionListRepository;
        }
        public async Task<IEnumerable<SubscriptionDescriptionList>> HandleGetSubscriptionDescriptionListAsync()
        {
            return await _subscriptionDescriptionListRepository.GetSubscriptionDescriptionList();
        }
    }
}
