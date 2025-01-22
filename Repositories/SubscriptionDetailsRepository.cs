using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface ISubscriptionDetailRepository
    {
        Task<List<SubscriptionDetail>> GetSubscriptionDetailsAsync();
    }
    public class SubscriptionDetailRepository : ISubscriptionDetailRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<ISubscriptionDetailRepository> _logger;

        public SubscriptionDetailRepository(DatabaseConnection dbConnection, ILogger<ISubscriptionDetailRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }
        public async Task<List<SubscriptionDetail>> GetSubscriptionDetailsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    return (await connection.QueryAsync<SubscriptionDetail>("[dbo].[GetSubscriptionDetails]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute subscriptiondetail.");
                throw new Exception("Failed to retrieve subscription detail.", ex);
            }
        }
    }
}


