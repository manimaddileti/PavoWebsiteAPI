using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class PageContentHandler
    {
        private readonly IPageContentRepository _pageContentRepository;

        public PageContentHandler(IPageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }

        public async Task<IEnumerable<PageContent>> GetPageContentAsync()
        {
            var pageContent = await _pageContentRepository.GetPageContentAsync();
            if (pageContent == null || !pageContent.Any())
            {
                throw new Exception("Page Content not found");
            }
            return pageContent;
        }
    }
}

