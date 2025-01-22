using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;

namespace PavoWebsiteDatabase.Repositories
{
    public interface IPageContentRepository
    {
        Task<List<PageContent>> GetPageContentAsync();
    }

    public class PageContentRepository : IPageContentRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<PageContentRepository> _logger;
        public PageContentRepository(DatabaseConnection dbConnection, ILogger<PageContentRepository> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }
        public async Task<List<PageContent>> GetPageContentAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var result = await connection.QueryAsync<PageContent>("[dbo].[GetPageContent]", new { }, commandType: CommandType.StoredProcedure);
                    return result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred while fetching page content: {ex.Message}");
                throw new Exception("Failed to retrieve page content.", ex);
            }
        }
    }
}
