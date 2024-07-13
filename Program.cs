using Microsoft.Extensions.Configuration;

class Program
{
    public static async Task Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var apiKey = configuration["OpenAI:ApiKey"];
        var assistant = new ProductivityAssistant(apiKey);
        await assistant.Run();
    }
}
