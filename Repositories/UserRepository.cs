
using System.Data;
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class UserRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public UserRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            using (var connection = _dbConnection.connection())
            {
                return await connection.QueryAsync<User>(
                    "GetAllUsers",
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}
