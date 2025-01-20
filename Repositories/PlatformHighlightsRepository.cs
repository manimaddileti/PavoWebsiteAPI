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
        public async Task<IEnumerable<PlatformHighlight>> GetPlatformHighlights()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<PlatformHighlight>("[dbo].[GetPlatformHighlights]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

