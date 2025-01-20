using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Collections.Generic;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class SubscriptionDescriptionListRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public SubscriptionDescriptionListRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<SubscriptionDescriptionList>> GetSubscriptionDescriptionList()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<SubscriptionDescriptionList>("[dbo].[GetSubscriptionDescriptionList]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

