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

        public async Task<IEnumerable<Menu>> GetAllMenus()
        {

            using (var connection = _dbConnection.connection())
            {
                return await connection.QueryAsync<Menu>("GetAllMenus", new { }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
