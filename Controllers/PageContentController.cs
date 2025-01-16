using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageContentController : ControllerBase
    {
        private readonly PageContentRepository _pageContentRepository;

        public PageContentController(PageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PageContent>>> GetAllPageContent()
        {
            try
            {
                var pageContent = await _pageContentRepository.GetAllPageContent();
                return Ok(pageContent);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}
