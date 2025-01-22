using System.Data;
using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IPlatformHighlightsRepository
    {
        Task<List<PlatformHighlight>> GetPlatformHighlightsAsync();
    }
    public class PlatformHighlightsRepository : IPlatformHighlightsRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<PlatformHighlightsRepository> _logger;

        public PlatformHighlightsRepository(DatabaseConnection dbConnection, ILogger<PlatformHighlightsRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<PlatformHighlight>> GetPlatformHighlightsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var result = await connection.QueryAsync<PlatformHighlight>("[dbo].[GetPlatformHighlights]", new { }, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching platform highlights: {ex.Message}");
                throw new Exception("Failed to retrieve platform highlights.", ex);
            }
        }
    }
}
