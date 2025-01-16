
using System.Data;
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class PlatformHighlightsRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public PlatformHighlightsRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<PlatformHighlight>> GetAllPlatformHighlights()
        {
            using (var connection = _dbConnection.connection())  
            {
                return await connection.QueryAsync<PlatformHighlight>("GetAllPlatformHighlights", new {},commandType:CommandType.StoredProcedure);
            }
        }
    }
}
