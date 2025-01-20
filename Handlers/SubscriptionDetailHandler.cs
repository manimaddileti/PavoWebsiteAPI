using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class SubscriptionDetailHandler
    {
        private readonly SubscriptionDetailRepository _subscriptionDetailRepository;

        public SubscriptionDetailHandler(SubscriptionDetailRepository subscriptionDetailRepository)
        {
            _subscriptionDetailRepository = subscriptionDetailRepository;
        }
        public async Task<IEnumerable<SubscriptionDetail>> HandleGetSubscriptionDetailsAsync()
        {
            return await _subscriptionDetailRepository.GetSubscriptionDetails();
        }
    }
}
