using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class FooterHandler
    {
        private readonly FooterRepository _footerRepository;

        public FooterHandler(FooterRepository footerRepository)
        {
            _footerRepository = footerRepository;
        }

        public async Task<List<Footer>> GetFooterAsync()
        {
            return await _footerRepository.GetFooterAsync();
        }
    }
}
