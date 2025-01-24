using PavoWebsiteDatabase.Models;
using PavoWebsiteDatabase.Repositories;

public class ActivityMetricsHandler
{
    private readonly IActivityMetricsRepository _activityMetricsRepository;


    public ActivityMetricsHandler(IActivityMetricsRepository activityMetricsRepository)
    {
        _activityMetricsRepository = activityMetricsRepository;
    }

    public async Task<List<ActivityMetrics>> GetActivityMetricsAsync()
    {
        var activityMatrices =   await _activityMetricsRepository.GetActivityMetricsAsync();

        if (activityMatrices == null || !activityMatrices.Any())
            throw new  Exception("Not found");

        return activityMatrices;
    }
}

