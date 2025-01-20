using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PavoWebsiteDatabase.Repositories
{
    public class TestmonialRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public TestmonialRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<Testmonial>> GetTestmonials()
        {
            using (var connection = _dbConnection.connection())
            {
                return (await connection.QueryAsync<Testmonial>("[dbo].[GetTestimonial]", new { }, commandType: CommandType.StoredProcedure)).ToList();
            }
        }
    }
}

