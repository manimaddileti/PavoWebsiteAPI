

using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public class TestmonialRepository
    {
        private readonly DatabaseConnection _dbConnection;

        public TestmonialRepository(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<IEnumerable<Testmonial>> GetAllTestmonials()
        {

            using (var connection = _dbConnection.connection())
            {
                return await connection.QueryAsync<Testmonial>("GetAllTestimonial", new {},commandType:CommandType.StoredProcedure);
            }
        }
    }
}

