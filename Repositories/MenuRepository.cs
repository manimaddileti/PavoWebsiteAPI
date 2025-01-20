using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class MenuRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public MenuRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Menu>> GetMenusAsync()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<Menu>("[dbo].[GetMenus]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}
