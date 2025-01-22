using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IMenuRepository
    {
        Task<List<Menu>> GetMenusAsync();
    }

    public class MenuRepository : IMenuRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<MenuRepository> _logger;

        public MenuRepository(DatabaseConnection dbConnection, ILogger<MenuRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<Menu>> GetMenusAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var result = await connection.QueryAsync<Menu>("[dbo].[GetMenus]", new { }, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching menus: {ex.Message}");
                throw new Exception("Failed to retrieve menus.", ex);
            }
        }
    }
}
