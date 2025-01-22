using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IActivityMetricsRepository
    {
        public Task<List<ActivityMetrics>> GetActivityMetricsAsync();
    }
    public class ActivityMetricsRepository : IActivityMetricsRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<IActivityMetricsRepository> _logger;

        public ActivityMetricsRepository(DatabaseConnection dbConnection, ILogger<IActivityMetricsRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<ActivityMetrics>> GetActivityMetricsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {

                    return (await connection.QueryAsync<ActivityMetrics>("[dbo].[GetActivityMetrics]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Failed to execute");
                throw new Exception("Failed to retrive list", ex);
            }
        }
    }
}
