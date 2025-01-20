
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Collections.Generic;
using System.Data;


namespace PavoWebsiteDatabase.Repositories
{
    public class PageContentRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public PageContentRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<PageContent>> GetPageContent()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<PageContent>("[dbo].[GetPageContent]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

