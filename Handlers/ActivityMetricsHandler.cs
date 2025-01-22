using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

public class ActivityMetricsHandler
{
    private readonly ActivityMetricsRepository _activityMetricsRepository;

    public ActivityMetricsHandler(ActivityMetricsRepository activityMetricsRepository)
    {
        _activityMetricsRepository = activityMetricsRepository;
    }

    public async Task<List<ActivityMetrics>> GetActivityMetricsAsync()
    {
        return await _activityMetricsRepository.GetActivityMetricsAsync();
    }
}

