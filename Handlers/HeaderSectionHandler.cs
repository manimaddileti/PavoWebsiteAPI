using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class HeaderSectionHandler
    {
        private readonly IHeaderSectionRepository _headerSectionRepository;

        public HeaderSectionHandler(IHeaderSectionRepository headerSectionRepository)
        {
            _headerSectionRepository = headerSectionRepository;
        }

        public async Task<List<HeaderSection>> GetHeaderSectionsAsync()
        {
            var headerSections = await _headerSectionRepository.GetHeaderSectionsAsync();
            if (headerSections == null || !headerSections.Any())
                throw new Exception("Not found.");
            return headerSections;
        }
    }
}
