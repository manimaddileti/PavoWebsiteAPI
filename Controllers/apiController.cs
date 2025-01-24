using Microsoft.AspNetCore.Mvc;
using PavoWebsiteDatabase.Handlers;
using PavoWebsiteDatabase.Models;


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
        private readonly FooterHandler _footerHandler;



        public apiController(
            ActivityMetricsHandler activityMetricsHandler,
            HeaderSectionHandler headerSectionHandler,
            MenuHandler menuHandler,
            PageContentHandler pageContentHandler,
            PlatformHighlightsHandler platformHighlightsHandler,
            SubscriptionDescriptionListHandler subscriptionDescriptionListHandler,
            SubscriptionDetailHandler subscriptionDetailHandler,
            TestmonialHandler testmonialHandler,
            UserHandler userHandler,
            FooterHandler footerHandler)

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
            _footerHandler = footerHandler;
        }


        [HttpGet("ActivityMetrics")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<ActivityMetrics>>> GetActivityMetrics()
        {
            Console.WriteLine("user requesting for activity metrics!!");
            var activityMetrics = await _activityMetricsHandler.GetActivityMetricsAsync();
            return Ok(activityMetrics);
        }


        [HttpGet("HeaderSection")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHeaderSections()
        {
            var headerSections = await _headerSectionHandler.GetHeaderSectionsAsync();
            return Ok(headerSections);
        }



        [HttpGet("menus")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetMenus()
        {
            var menus = await _menuHandler.GetMenusAsync();
            return Ok(menus);
        }


        [HttpGet("PageContent")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllPageContent()
        {
            var pageContent = await _pageContentHandler.GetPageContentAsync();
            return Ok(pageContent);
        }



        [HttpGet("PlatformHighlights")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<PlatformHighlight>>> GetPlatformHighlights()
        {
            var highlights = await _platformHighlightsHandler.GetPlatformHighlightsAsync();
            if (highlights == null)
            {
                return NotFound("data cannot be found ");
            }
            return Ok(highlights);
        }



        [HttpGet("SubscriptionDescriptionList")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<SubscriptionDescriptionList>>> GetSubscriptionDescriptionList()
        {
            var subscriptionDescriptionList = await _subscriptionDescriptionListHandler.GetSubscriptionDescriptionListAsync();
            return Ok(subscriptionDescriptionList);
        }


        [HttpGet("SubscriptionDetail")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<SubscriptionDetail>>> GetSubscriptionDetails()
        {
            var subscriptionDetails = await _subscriptionDetailHandler.GetSubscriptionDetailsAsync();
            return Ok(subscriptionDetails);
        }



        [HttpGet("Testmonials")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<Testmonial>>> GetTestmonialsAsync()
        {
            var testmonials = await _testmonialHandler.GetTestmonialsAsync();
            return Ok(testmonials);
        }



        [HttpGet("Users")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userHandler.GetUsersAsync();
            return Ok(users);
        }

        [HttpGet("Footer")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<Footer>>> GetFooter()
        {
            var Footer = await _footerHandler.GetFooterAsync();
            return Ok(Footer);
        }
    }


}

