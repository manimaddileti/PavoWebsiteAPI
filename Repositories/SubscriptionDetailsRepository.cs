using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PavoWebsiteDatabase.Repositories
{
    public class SubscriptionDetailRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public SubscriptionDetailRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<SubscriptionDetail>> GetSubscriptionDetails()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<SubscriptionDetail>("[dbo].[GetSubscriptionDetails]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}


