using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeaderSectionController : ControllerBase
    {
        private readonly HeaderSectionRepository _headerSectionRepository;

        public HeaderSectionController(HeaderSectionRepository headerSectionRepository)
        {
            _headerSectionRepository = headerSectionRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHeaderSections()
        {
            try
            {
                var headerSections = await _headerSectionRepository.GetAllHeaderSections();
                return Ok(headerSections);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}

