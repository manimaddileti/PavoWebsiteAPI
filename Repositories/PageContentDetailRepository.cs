
using System.Data;
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class PageContentDetailRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public PageContentDetailRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<PageContentDetail>> GetAllPageContentDetails()
        {

            using (var connection = _dbConnection.connection()) 
            {
                return await connection.QueryAsync<PageContentDetail>("GetAllPageContentDetail", new {},commandType:CommandType.StoredProcedure);
            }
        }
    }
}

