
using Dapper;
using System.Data;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class PageContentRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public PageContentRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<PageContent>> GetAllPageContent()
        {
         

            using (var connection = _dbConnection.connection())  
            {
                return await connection.QueryAsync<PageContent>("GetAllPageContent", new {},commandType:CommandType.StoredProcedure);
            }
        }
    }
}
