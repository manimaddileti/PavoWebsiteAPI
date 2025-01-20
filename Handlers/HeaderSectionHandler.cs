using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class HeaderSectionHandler
    {
        private readonly HeaderSectionRepository _headerSectionRepository;

        public HeaderSectionHandler(HeaderSectionRepository headerSectionRepository)
        {
            _headerSectionRepository = headerSectionRepository;
        }

        public async Task<IEnumerable<HeaderSection>> GetHeaderSectionsAsync()
        {
           
            return await _headerSectionRepository.GetHeaderSectionsAsync();
        }
    }
}
