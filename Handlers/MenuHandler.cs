using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

namespace PavoWebsiteDatabase.Handlers
{
    public class MenuHandler
    {
        private readonly IMenuRepository _menuRepository;

        public MenuHandler(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<Menu>> GetMenusAsync()
        {
            var menus = await _menuRepository.GetMenuRepositoryAsync();
            if (menus == null || !menus.Any())
            {
                throw new Exception("menus not found");
            }
            return menus;
        }
    }
}
