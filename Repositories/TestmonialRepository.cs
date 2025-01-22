using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface ITestmonialRepository
    {
        Task<List<Testmonial>> GetTestmonialsAsync();
    }
    public class TestmonialRepository : ITestmonialRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<ITestmonialRepository> _logger;

        public TestmonialRepository(DatabaseConnection dbConnection, ILogger<ITestmonialRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }
        public async Task<List<Testmonial>> GetTestmonialsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    return (await connection.QueryAsync<Testmonial>("[dbo].[GetTestimonial]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute testmonials.");
                throw new Exception("Failed to retrieve testmonials list.", ex);
            }
           
        }
    }
}

