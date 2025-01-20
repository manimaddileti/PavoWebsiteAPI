using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public UserRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<User>> GetUser()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<User>("[dbo].[GetUser]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

