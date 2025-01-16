using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformHighlightsController : ControllerBase
    {
        private readonly PlatformHighlightsRepository _platformHighlightsRepository;

        public PlatformHighlightsController(PlatformHighlightsRepository platformHighlightsRepository)
        {
            _platformHighlightsRepository = platformHighlightsRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformHighlight>>> GetAllPlatformHighlights()
        {
            try
            {
                var platformHighlights = await _platformHighlightsRepository.GetAllPlatformHighlights();
                return Ok(platformHighlights);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}

