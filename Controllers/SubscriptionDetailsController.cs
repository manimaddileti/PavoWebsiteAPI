using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionDetailController : ControllerBase
    {
        private readonly SubscriptionDetailRepository _subscriptionDetailRepository;

        public SubscriptionDetailController(SubscriptionDetailRepository subscriptionDetailRepository)
        {
            _subscriptionDetailRepository = subscriptionDetailRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubscriptionDetail>>> GetAllSubscriptionDetails()
        {
            try
            {
                var subscriptionDetails = await _subscriptionDetailRepository.GetAllSubscriptionDetails();
                return Ok(subscriptionDetails);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}
