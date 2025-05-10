using Quartz;

namespace Philosophers_Catalogue.Controllers;

public static class DeveloperController
{
    public static void SetDeveloperEndpoints(this WebApplication app)
    {
        app.MapGet("/triggerParserJob", async (ISchedulerFactory schedulerFactory) =>
        {
            var scheduler = await schedulerFactory.GetScheduler();
            await scheduler.TriggerJob(new JobKey(nameof(WikipediaApiParser)));

            return Results.Ok("Job was completed successfully.");
        });
    }
}