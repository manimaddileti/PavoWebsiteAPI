using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class FooterRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public FooterRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<Footer>> GetFooterAsync()
        {
            using (var connection = _dbConnection.connection())
            {

                return (await connection.QueryAsync<Footer>("[dbo].[GetFooter]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}
