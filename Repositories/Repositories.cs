using Dapper;
using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.DatabaseConnect;
using System.Data;


namespace PavoWebsiteDatabase.Repositories
{
    public interface IActivityMetricsRepository
    {
        Task<List<ActivityMetrics>> GetActivityMetricsAsync();
    }
    public interface IFooterRepository
    {
        Task<List<Footer>> GetFooterAsync();
    }
    public interface IHeaderSectionRepository
    {
        Task<List<HeaderSection>> GetHeaderSectionsAsync();
    }
    public interface IMenuRepository
    {
        Task<List<Menu>> GetMenuRepositoryAsync();
    }
    public interface IPageContentRepository
    {
        Task<List<PageContent>> GetPageContentAsync();
    }
    public interface IPlatformHighlightsRepository
    {
        Task<List<PlatformHighlight>> GetPlatformHighlightsAsync();
    }
    public interface ISubscriptionDescriptionListRepository
    {
        Task<List<SubscriptionDescriptionList>> GetSubscriptionDescriptionListAsync();
    } 
    public interface ISubscriptionDetailsRepository
    {
        Task<List<SubscriptionDetail>> GetSubscriptionDetailsAsync();
    }
    public interface ITestmonialRepository
    {
        Task<List<Testmonial>> GetTestmonialsAsync();
    }
    public interface IUserRepository
    {
        Task<List<User>> GetUserRepositoryAsync();
    }

    


    public class Repositories : IActivityMetricsRepository, IFooterRepository, IHeaderSectionRepository, IMenuRepository , IPageContentRepository ,IPlatformHighlightsRepository , ISubscriptionDescriptionListRepository , ISubscriptionDetailsRepository, ITestmonialRepository ,IUserRepository
    {
        private readonly DatabaseConnection _dbConnection;
        private readonly ILogger<Repositories> _logger;

        public Repositories(DatabaseConnection dbConnection, ILogger<Repositories> logger)
        {
            _dbConnection = dbConnection;
            _logger = logger;
        }

        public async Task<List<ActivityMetrics>> GetActivityMetricsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var activityMetrics = await connection.QueryAsync<ActivityMetrics>("[dbo].[GetActivityMetrics]", new { }, commandType: CommandType.StoredProcedure);
                    return activityMetrics.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute GetActivityMetricsAsync.");
                throw new Exception("Failed to retrieve activity metrics list.", ex);
            }
        }

        public async Task<List<Footer>> GetFooterAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var footer = await connection.QueryAsync<Footer>("[dbo].[GetFooter]", new { }, commandType: CommandType.StoredProcedure);
                    return footer.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute GetFooterAsync.");
                throw new Exception("Failed to retrieve footer list.", ex);
            }
        }

        public async Task<List<HeaderSection>> GetHeaderSectionsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var headerSections = await connection.QueryAsync<HeaderSection>("[dbo].[GetHeaderSections]", new { }, commandType: CommandType.StoredProcedure);
                    return headerSections.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to execute GetHeaderSectionsAsync.");
                throw new Exception("Failed to retrieve header sections list.", ex);
            }
        }

        public async Task<List<Menu>> GetMenuRepositoryAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var Menus = await connection.QueryAsync<Menu>("[dbo].[GetMenus]", new { }, commandType: CommandType.StoredProcedure);
                    return Menus.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute GetMenus");
                throw new Exception("Failed to retrive menus section list", ex);
            }

        }

        public async Task<List<PageContent>> GetPageContentAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var PageContentdata = await connection.QueryAsync<PageContent>("[dbo].[GetPageContent]", new { }, commandType: CommandType.StoredProcedure);
                    return PageContentdata.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute GetPageContent");
                throw new Exception("Failed to retrive GetPageContent section list", ex);
            }

        }

        public async Task<List<PlatformHighlight>> GetPlatformHighlightsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var Platformdata = await connection.QueryAsync<PlatformHighlight>("[dbo].[GetPlatformHighlights]", new { }, commandType: CommandType.StoredProcedure);
                    return Platformdata.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute PlatformHighlight");
                throw new Exception("Failed to retrive PlatformHighlight section list", ex);
            }

        }

        public async Task<List<SubscriptionDescriptionList>> GetSubscriptionDescriptionListAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var SubscriptionList = await connection.QueryAsync<SubscriptionDescriptionList>("[dbo].[GetSubscriptionDescriptionList]", new { }, commandType: CommandType.StoredProcedure);
                    return SubscriptionList.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute SubscriptionList");
                throw new Exception("Failed to retrive SubscriptionDescription section list", ex);
            }

        }

        public async Task<List<SubscriptionDetail>> GetSubscriptionDetailsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var Subscriptiondetails = await connection.QueryAsync<SubscriptionDetail>("[dbo].[GetSubscriptionDetails]", new { }, commandType: CommandType.StoredProcedure);
                    return Subscriptiondetails.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute SubscriptionDetail");
                throw new Exception("Failed to retrive SubscriptionDetail section list", ex);
            }

        }

        public async Task<List<Testmonial>> GetTestmonialsAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var test = await connection.QueryAsync<Testmonial>("[dbo].[GetTestimonial]", new { }, commandType: CommandType.StoredProcedure);
                    return test.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute Testmonial");
                throw new Exception("Failed to retrive Testmonial section list", ex);
            }

        }

        public async Task<List<User>> GetUserRepositoryAsync()
        {
            try
            {
                using (var connection = _dbConnection.connection())
                {
                    var users = await connection.QueryAsync<User>("[dbo].[GetUser]", new { }, commandType: CommandType.StoredProcedure);
                    return users.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "failed to execute User");
                throw new Exception("Failed to retrive User section list", ex);
            }

        }

    }
}
