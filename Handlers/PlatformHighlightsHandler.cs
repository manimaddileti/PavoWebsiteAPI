using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class PlatformHighlightsHandler
    {
        private readonly IPlatformHighlightsRepository _platformHighlightsRepository;

        public PlatformHighlightsHandler(IPlatformHighlightsRepository platformHighlightsRepository)
        {
            _platformHighlightsRepository = platformHighlightsRepository;
        }
        public async Task<IEnumerable<PlatformHighlight>> GetPlatformHighlightsAsync()
        {
            var platformHighlights = await _platformHighlightsRepository.GetPlatformHighlightsAsync();
            if (platformHighlights == null || !platformHighlights.Any())
                throw new Exception("PlatformHighlights not found");
            return platformHighlights;
        }
    }
}
