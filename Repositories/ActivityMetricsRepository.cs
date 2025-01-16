
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
        public async Task<IEnumerable<ActivityMetrics>> GetAllActivityMetrics()
        {

            using (var connection = _dbConnection.connection())  
            {
                return await connection.QueryAsync<ActivityMetrics>("GetAllActivityMetrics", new { }, commandType:CommandType.StoredProcedure); 
            }
        }
    }
}
