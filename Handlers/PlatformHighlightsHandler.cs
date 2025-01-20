using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class PlatformHighlightsHandler
    {
        private readonly PlatformHighlightsRepository _platformHighlightsRepository;

        public PlatformHighlightsHandler(PlatformHighlightsRepository platformHighlightsRepository)
        {
            _platformHighlightsRepository = platformHighlightsRepository;
        }
        public async Task<IEnumerable<PlatformHighlight>> HandleGetPlatformHighlightsAsync()
        {
            return await _platformHighlightsRepository.GetPlatformHighlights();
        }
    }
}
