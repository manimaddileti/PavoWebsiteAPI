using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface ISubscriptionDescriptionListRepository
    {
        Task<List<SubscriptionDescriptionList>> GetSubscriptionDescriptionListAsync();
    }
    public class SubscriptionDescriptionListRepository : ISubscriptionDescriptionListRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<SubscriptionDescriptionListRepository> _logger;
        public SubscriptionDescriptionListRepository(DatabaseConnection dbConnection, ILogger<SubscriptionDescriptionListRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }
        public async Task<List<SubscriptionDescriptionList>> GetSubscriptionDescriptionListAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var result = await connection.QueryAsync<SubscriptionDescriptionList>("[dbo].[GetSubscriptionDescriptionList]", new { }, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to execute GetSubscriptionDescriptionListAsync.");
                throw new Exception("Failed to retrieve subscription description list.", ex);
            }
        }
    }
}
