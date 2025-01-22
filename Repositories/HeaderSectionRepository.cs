using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;


namespace PavoWebsiteDatabase.Repositories
{
    public interface IHeaderSectionRepository
    {
        Task<List<HeaderSection>> GetHeaderSectionsAsync();
    }
    public class HeaderSectionRepository : IHeaderSectionRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<HeaderSectionRepository> _logger;

        public HeaderSectionRepository(DatabaseConnection dbConnection, ILogger<HeaderSectionRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<HeaderSection>> GetHeaderSectionsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    return (await connection.QueryAsync<HeaderSection>("[dbo].[GetHeaderSections]", new { }, commandType: CommandType.StoredProcedure)).ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching header sections: {ex.Message}");
                throw new Exception("Failed to retrieve header sections.", ex);
            }
        }
    }
}
