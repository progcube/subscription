# Probcube Subscriptions

This package provides quick support for subscription products.

## Dependencies

You need to add [Progcube.Core](https://github.com/progcube/core) first.

## Installation

(NuGet package not available yet.)

Clone the repository and run the following command in your application folder:

```
dotnet add reference ../Progcube/Subscriptions/Progcube.Subscriptions.csproj
```

Alternatively, add the following to your csproj:

```
<ItemGroup>
    <ProjectReference Include="../Progcube/Subscriptions/Progcube.Subscriptions.csproj" />
</ItemGroup>
```

Finally, bind the Progcube framework in the ConfigureServices() method of your application's Startup.cs:

```
public void ConfigureServices(IServiceCollection services)
{
    // ...

    ProgcubeFramework.Bind(services, new []{    // Requires Progcube.Core
        typeof(YourApplication.Startup),        // Your own application
        typeof(Progcube.Subscriptions.Startup)  // List all Progcube dependencies you are using
    });

    // ...
}
```
