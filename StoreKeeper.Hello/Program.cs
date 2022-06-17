using Microsoft.Extensions.DependencyInjection;

// Make sure that add dotnet7 feed to nuget config, if you are not on latest Preview 6
// which is downloaded after Jun 17 2022.

// Build your DI container as usual.
var serviceCollection = new ServiceCollection();
serviceCollection.AddScoped<ConsoleWrapper>();
var provider = serviceCollection.BuildServiceProvider();

// Use your service provider as usual.
var wrapper = provider.GetRequiredService<ConsoleWrapper>();
wrapper.WriteLine("Bye Bye Reflection!");

class ConsoleWrapper
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}