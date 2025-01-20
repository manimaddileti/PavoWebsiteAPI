using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class HeaderSectionRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public HeaderSectionRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<HeaderSection>> GetHeaderSectionsAsync()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<HeaderSection>("[dbo].[GetHeaderSections]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}


