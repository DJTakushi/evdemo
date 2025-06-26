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
            // works, but env-vars are not visible by other processes (E.G.: docker inspect)
            // const string ENV_FILEPATH = "/host.env";
            // _logger.LogInformation($"Loading environment variables from {ENV_FILEPATH}");

            // if (File.Exists(ENV_FILEPATH))
            // {
            //     foreach (string line in File.ReadLines(ENV_FILEPATH))
            //     {
            //         if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
            //             continue; // Skip empty lines and comments

            //         string[] line_parts = line.Split('=', 2); // max split  2
            //         if (line_parts.Length != 2)
            //             continue; // Skip lines that are not key-value pairs


            //         var key = line_parts[0].Trim();
            //         var value = line_parts[1].Trim();
            //         _logger.LogInformation($"setting '{key}' env-var to '{value}'");
            //         Environment.SetEnvironmentVariable(key, value);
            //     }
            // }
            // else
            // {
            //     _logger.LogWarning($"Environment file {ENV_FILEPATH} not found");
            // }


            // unhelpful right now
            // var configuration = new ConfigurationBuilder()
            //     .AddEnvironmentVariables()  // Add environment variables as a configuration source
            //     .Build();

            // string? connectionString = configuration["foo"];
            // if (!string.IsNullOrEmpty(connectionString))
            // {
            //     Environment.SetEnvironmentVariable("foo", connectionString);
            // }
            // else
            // {
            //     // string dval = $"MY_DEFAULT_FOO_{DateTime.Now:yyyyMMdd_HHmmss}";
            //     // Environment.SetEnvironmentVariable("foo", dval);
            // }

            // update env-var
            // string dval = $"MY_DEFAULT_FOO_{DateTime.Now:yyyyMMdd_HHmmss}";
            // Environment.SetEnvironmentVariable("foo", dval);



            if (_logger.IsEnabled(LogLevel.Information))
            {
                string foo_str = "EV foo : '" + Environment.GetEnvironmentVariable("foo") + "'";
                _logger.LogInformation("Worker running at: {time}, {foo_str}", DateTimeOffset.Now, foo_str);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
