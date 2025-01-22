using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>>GetUser();
    }
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger <IUserRepository> _logger;

        public UserRepository(DatabaseConnection dbConnection, ILogger <IUserRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }
        public async Task<List<User>> GetUser()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    return (await connection.QueryAsync<User>("[dbo].[GetUser]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
                {
                _logger.LogError(ex, "Failed to execute GetUser.");
                throw new Exception("Failed to retrieve User list.", ex);
            }
            
        }
    }
}

