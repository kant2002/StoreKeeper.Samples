StoreKeeper Samples
===================

This is samples for the [StoreKeeper](https://github.com/kant2002/storekeeper) which augments your DI container to make it work in Reflection-free mode.

You add Nuget package.

```sh
dotnet add package StoreKeeper
```

Then you add custom Nuget feed for latest NativeAOT compiler with fixes.
```sh
dotnet new nugetoconfig
```

Add `dotnet7` feed to nuget.config
```xml
<add key="dotnet7" value="https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet7/nuget/v3/index.json" />
```

And that's it unless you are using open generics as service registration.
```csharp
// Build your DI container as usual.
var serviceCollection = new ServiceCollection();
serviceCollection.AddScoped<ConsoleWrapper>();
var provider = serviceCollection.BuildServiceProvider();

// Use your service provider as usual.
var wrapper = provider.GetRequiredService<ConsoleWrapper>();
wrapper.WriteLine("Bye Bye Reflection!");
```