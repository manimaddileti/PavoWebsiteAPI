using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Repositories;  

namespace PavoWebsiteApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly MenuRepository _menuRepository;

        public MenuController(MenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllMenus()
        {
            try
            {
                var menus = await _menuRepository.GetAllMenus();
                return Ok(menus);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}


