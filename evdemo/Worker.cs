namespace evdemo;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                string foo_str = "EV foo : '" + Environment.GetEnvironmentVariable("foo") +"'";
                _logger.LogInformation("Worker running at: {time}, {foo_str}", DateTimeOffset.Now, foo_str);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
