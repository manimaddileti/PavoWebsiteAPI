using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IFooterRepository
    {
        Task<List<Footer>> GetFooterAsync();
    }

    public class FooterRepository : IFooterRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<IFooterRepository> _logger;

        public FooterRepository(DatabaseConnection dbConnection, ILogger<IFooterRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<Footer>> GetFooterAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    return (await connection.QueryAsync<Footer>("[dbo].[GetFooter]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute GetFooterAsync.");
                throw new Exception("Failed to retrieve footer list.", ex);
            }
        }
    }
}

