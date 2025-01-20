using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Handlers;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;


namespace PavoWebsiteApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        private readonly ActivityMetricsHandler _activityMetricsHandler;
        private readonly HeaderSectionHandler _headerSectionHandler;
        private readonly MenuHandler _menuHandler;
        private readonly PageContentHandler _pageContentHandler;
        private readonly PlatformHighlightsHandler _platformHighlightsHandler;
        private readonly SubscriptionDescriptionListHandler _subscriptionDescriptionListHandler;
        private readonly SubscriptionDetailHandler _subscriptionDetailHandler;
        private readonly TestmonialHandler _testmonialHandler;
        private readonly UserHandler _userHandler;

        public apiController(
            ActivityMetricsHandler activityMetricsHandler,
            HeaderSectionHandler headerSectionHandler,
            MenuHandler menuHandler,
            PageContentHandler pageContentHandler,
            PlatformHighlightsHandler platformHighlightsHandler,
            SubscriptionDescriptionListHandler subscriptionDescriptionListHandler,
            SubscriptionDetailHandler subscriptionDetailHandler,
            TestmonialHandler testmonialHandler,
            UserHandler userHandler)
        {
            _activityMetricsHandler = activityMetricsHandler;
            _headerSectionHandler = headerSectionHandler;
            _menuHandler = menuHandler;
            _pageContentHandler = pageContentHandler;
            _platformHighlightsHandler = platformHighlightsHandler;
            _subscriptionDescriptionListHandler = subscriptionDescriptionListHandler;
            _subscriptionDetailHandler = subscriptionDetailHandler;
            _testmonialHandler = testmonialHandler;
            _userHandler = userHandler;
        }



        [HttpGet("ActivityMetrics")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ActivityMetrics>>> GetActivityMetrics()
        {
            try
            {
                var activityMetrics = await _activityMetricsHandler.GetActivityMetricsAsync();
                if (activityMetrics == null || !activityMetrics.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(activityMetrics);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the ActivityMetrics.", Details = ex.Message });
            }
        }




        [HttpGet("HeaderSection")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetHeaderSections()
        {
            try
            {
                var headerSections = await _headerSectionHandler.GetHeaderSectionsAsync();
                if (headerSections == null || !headerSections.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(headerSections);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Header Sections.", Details = ex.Message });
            }
        }



        [HttpGet("menus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMenus()
        {
            try
            {
                var menus = await _menuHandler.GetMenusAsync();
                if (menus == null || !menus.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(menus);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Menus.", Details = ex.Message });
            }
        }


        [HttpGet("PageContent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllPageContent()
        {
            try
            {
                var pageContent = await _pageContentHandler.GetPageContentAsync();

                if (pageContent == null || !pageContent.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(pageContent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the PageContent.", Details = ex.Message });
            }
        }



        [HttpGet("PlatformHighlights")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PlatformHighlight>>> GetPlatformHighlights()
        {
            try
            {
                var highlights = await _platformHighlightsHandler.HandleGetPlatformHighlightsAsync();

                if (highlights == null || !highlights.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(highlights);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Platform Highlights.", Details = ex.Message });
            }
        }



        [HttpGet("SubscriptionDescriptionList")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<SubscriptionDescriptionList>>> GetSubscriptionDescriptionList()
        {
            try
            {
                var subscriptionDescriptionList = await _subscriptionDescriptionListHandler.HandleGetSubscriptionDescriptionListAsync();

                if (subscriptionDescriptionList == null || !subscriptionDescriptionList.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(subscriptionDescriptionList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Subscription Description List.", Details = ex.Message });
            }
        }


        [HttpGet("SubscriptionDetail")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<SubscriptionDetail>>> GetSubscriptionDetails()
        {
            try
            {
                var subscriptionDetails = await _subscriptionDetailHandler.HandleGetSubscriptionDetailsAsync();

                if (subscriptionDetails == null || !subscriptionDetails.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });
                return Ok(subscriptionDetails);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Subscription Details.", Details = ex.Message });
            }
        }



        [HttpGet("Testmonials")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Testmonial>>> GetTestmonials()
        {
            try
            {
                var testmonials = await _testmonialHandler.HandleGetTestmonialsAsync();
                if (testmonials == null || !testmonials.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });
                return Ok(testmonials);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Testmonials.", Details = ex.Message });
            }
        }



        [HttpGet("Users")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userHandler.HandleGetUsersAsync();

                if (users == null || !users.Any())
                    return NotFound(new { Message = "Not Found.", StatusCode = 404 });

                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while fetching the Users.", Details = ex.Message });
            }
        }

    }
}

