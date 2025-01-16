
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class SubscriptionDetailRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public SubscriptionDetailRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<SubscriptionDetail>> GetAllSubscriptionDetails()
        {

            using (var connection = _dbConnection.connection())  
            {
                return await connection.QueryAsync<SubscriptionDetail>("GetAllSubscriptionDetails", new {},commandType:System.Data.CommandType.StoredProcedure);
            }
        }
    }
}


