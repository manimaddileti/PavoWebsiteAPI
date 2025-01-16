using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestmonialController : ControllerBase
    {
        private readonly TestmonialRepository _testmonialRepository;

        public TestmonialController(TestmonialRepository testmonialRepository)
        {
            _testmonialRepository = testmonialRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testmonial>>> GetAllTestmonials()
        {
            try
            {
                var testmonials = await _testmonialRepository.GetAllTestmonials();
                return Ok(testmonials);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error : {ex.Message}");
            }
        }
    }
}