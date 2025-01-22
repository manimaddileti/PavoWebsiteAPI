using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class SubscriptionDetailHandler
    {
        private readonly ISubscriptionDetailRepository _subscriptionDetailRepository;

        public SubscriptionDetailHandler(ISubscriptionDetailRepository subscriptionDetailRepository)
        {
            _subscriptionDetailRepository = subscriptionDetailRepository;
        }
        public async Task<IEnumerable<SubscriptionDetail>> GetSubscriptionDetailsAsync()
        {
            var subscriptionDetails =  await _subscriptionDetailRepository.GetSubscriptionDetailsAsync();
            if (subscriptionDetails == null || !subscriptionDetails.Any())
            {
                throw new Exception("Subscription detail not found");
            }
            return subscriptionDetails;
        }
    }
}
