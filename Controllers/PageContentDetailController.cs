using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageContentDetailController : ControllerBase
    {
        private readonly PageContentDetailRepository _pageContentDetailRepository;

        public PageContentDetailController(PageContentDetailRepository pageContentDetailRepository)
        {
            _pageContentDetailRepository = pageContentDetailRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PageContentDetail>>> GetAllPageContentDetails()
        {
            try
            {
                var pageContentDetails = await _pageContentDetailRepository.GetAllPageContentDetails();
                return Ok(pageContentDetails);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}
