using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class MenuHandler
    {
        private readonly MenuRepository _menuRepository;

        public MenuHandler(MenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<Menu>> GetMenusAsync()
        {
            return await _menuRepository.GetMenusAsync();
        }
    }
}
