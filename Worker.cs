using System.Diagnostics;

namespace AbortShutdownWorker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> logger;

    public Worker(ILogger<Worker> logger)
    {
        this.logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (logger.IsEnabled(LogLevel.Information))
            {
                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
            
            Process.Start("shutdown", "/a");

            await Task.Delay(Constants.RunTimeout, stoppingToken);
        }
    }
}