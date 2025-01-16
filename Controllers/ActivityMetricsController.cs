using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;
namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityMetricsController : ControllerBase
    {
        private readonly ActivityMetricsRepository _activityMetricsRepository;

        public ActivityMetricsController(ActivityMetricsRepository activityMetricsRepository)
        {
            _activityMetricsRepository = activityMetricsRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityMetrics>>> GetAllActivityMetrics()
        {
            try
            {
                var activityMetrics = await _activityMetricsRepository.GetAllActivityMetrics();
                return Ok(activityMetrics);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }

        }
    }
}

