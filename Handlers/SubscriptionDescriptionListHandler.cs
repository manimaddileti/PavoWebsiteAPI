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
        public async Task<IEnumerable<SubscriptionDescriptionList>> HandleGetSubscriptionDescriptionListAsync()
        {
            var subscriptionDescriptionList = await _subscriptionDescriptionListRepository.GetSubscriptionDescriptionListAsync();
            if (subscriptionDescriptionList == null || !subscriptionDescriptionList.Any())
            {
                throw new Exception("subscription description list not found");
            }
            return subscriptionDescriptionList;
        }
    }
}
