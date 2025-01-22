using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class FooterHandler
    {
        private readonly IFooterRepository _footerRepository;

        public FooterHandler(IFooterRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }

        public async Task<List<Footer>> GetFooterAsync()
        {
            var footers = await _footerRepository.GetFooterAsync();

            if (footers == null || !footers.Any())
            {
                throw new Exception("Footer not found.");
            }

            return footers;
        }
    }
}

