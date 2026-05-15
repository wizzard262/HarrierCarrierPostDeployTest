using Microsoft.Extensions.Configuration;

namespace HarrierCarrierPostDeployTest.Support;

public static class TestConfig
{
    private static readonly IConfigurationRoot _config;

    static TestConfig()
    {
        _config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
    }

    public static string BaseUrl => _config["BaseUrl"];
}
