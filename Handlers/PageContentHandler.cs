using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class PageContentHandler
    {
        private readonly PageContentRepository _pageContentRepository;

        public PageContentHandler(PageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }

        public async Task<IEnumerable<PageContent>> GetPageContentAsync()
        {
            return await _pageContentRepository.GetPageContent();
        }
    }
}

