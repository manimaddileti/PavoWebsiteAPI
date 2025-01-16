
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
        public async Task<IEnumerable<HeaderSection>> GetAllHeaderSections()
        {
            using (var connection = _dbConnection.connection())
            {
                return await connection.QueryAsync<HeaderSection> ("GetAllHeaderSections", new { }, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

