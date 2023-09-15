using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Formatting.Json;

namespace Infrastructure.Configuration.Configuration
{
    public static class LoggingConfiguration
    {
        private const string SERILOG_FILEPATH = "Serilog:filepath";
        //private const string SERILOG_CLOUDWATCHGROUP = "Serilog:CloudWatchGroup";
        private const string SERILOG_OUTPUTTEMPLATE = "Serilog:outputTemplate";
        //private const string AWS_REGION = "AWS:Region";
        private const string APPLICATION_SOLUTION = "Application:Solution";
        private const string APPLICATION_NAME = "Application:Name";
        private const string VALUE_CANNOT_BE_NULL = "Valor não pode ser nulo.";

        public static ILogger CreateLogger()
        {
            IConfiguration configuration = Configuration();

            var formatter = new JsonFormatter();

            //var options = new CloudWatchSinkOptions
            //{
            //    LogGroupName = GetConfiguration(configuration, SERILOG_CLOUDWATCHGROUP),
            //    BatchSizeLimit = 100,
            //    TextFormatter = formatter,
            //    Period = TimeSpan.FromSeconds(10),
            //    CreateLogGroup = true,
            //    LogStreamNameProvider = new DefaultLogStreamProvider(),
            //    RetryAttempts = 5,
            //    LogGroupRetentionPolicy = LogGroupRetentionPolicy.OneWeek
            //};

            //var region = RegionEndpoint.GetBySystemName(GetConfiguration(configuration, AWS_REGION));

            //var client = new AmazonCloudWatchLogsClient(region);

            return new LoggerConfiguration()
                .Enrich.WithProperty("environment", EnvironmentConfiguration.ENV)
                .Enrich.WithProperty("solution", GetConfiguration(configuration, APPLICATION_SOLUTION))
                .Enrich.WithProperty("application", GetConfiguration(configuration, APPLICATION_NAME))
                .ReadFrom.Configuration(configuration)
                .WriteTo.Console()
                //.WriteTo.AmazonCloudWatch(options, client)
                .WriteTo.File(path: GetConfiguration(configuration, SERILOG_FILEPATH),
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: GetConfiguration(configuration, SERILOG_OUTPUTTEMPLATE))
                .CreateLogger();
        }

        private static IConfiguration Configuration() => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{EnvironmentConfiguration.ENV}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        private static string GetConfiguration(IConfiguration configuration, string key)
        {
            return configuration[key] ?? throw new ArgumentNullException(key, VALUE_CANNOT_BE_NULL);
        }
    }
}
