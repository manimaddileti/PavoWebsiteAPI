
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public class SubscriptionDescriptionListRepository
    {
        private readonly DatabaseConnection _dbConnection;
        public SubscriptionDescriptionListRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<SubscriptionDescriptionList>> GetAllSubscriptionDescriptionList()
        {

            using (var connection = _dbConnection.connection())  
            {
                return await connection.QueryAsync<SubscriptionDescriptionList>("GetAllSubscriptionDescriptionList", new {},commandType:System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
