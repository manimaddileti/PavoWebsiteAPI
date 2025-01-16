using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionDescriptionListController : ControllerBase
    {
        private readonly SubscriptionDescriptionListRepository _subscriptionDescriptionListRepository;

        public SubscriptionDescriptionListController(SubscriptionDescriptionListRepository subscriptionDescriptionListRepository)
        {
            _subscriptionDescriptionListRepository = subscriptionDescriptionListRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionDescriptionList>>> GetAllSubscriptionDescriptionList()
        {
            try
            {
                var subscriptionDescriptionList = await _subscriptionDescriptionListRepository.GetAllSubscriptionDescriptionList();
                return Ok(subscriptionDescriptionList);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}

