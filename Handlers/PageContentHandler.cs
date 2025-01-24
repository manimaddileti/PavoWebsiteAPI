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

        public async Task<List<PageContent>> GetPageContentAsync()
        {
            var pagedata = await _pageContentRepository.GetPageContentAsync();
            if (pagedata == null || !pagedata.Any())
            {
                throw new Exception("Page Content not found");
            }
            return pagedata;
        }
    }
}

