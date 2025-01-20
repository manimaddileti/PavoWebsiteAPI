using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class ActivityMetricsRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public ActivityMetricsRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<ActivityMetrics>> GetActivityMetricsAsync()
        {
            using (var connection = _dbConnection.connection())
            {
              
                return (await connection.QueryAsync<ActivityMetrics>("[dbo].[GetActivityMetrics]",new { },commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}
