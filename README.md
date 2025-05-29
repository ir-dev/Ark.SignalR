# Ark.SignalR!

This is a simple c# signal-r library, made it flexible for developers to use the socket connection.
nuget install:
[![Generic badge](https://img.shields.io/nuget/v/Ark.SignalR?color=green&label=nuget&style=for-the-badge)](https://www.nuget.org/packages/Ark.SignalR)
````
    NuGet Install-Package Ark.SignalR
````

1. Ark.SignalR - enable dependency injection
use below code in DI registration at library level:

````
   builder.Services.AddArkSignalR();

   app.UseArkSignalR("pattern");
````

TO DOs:
- 

expected issue:

- large dataset perf issues

**Author: Immanuel R (raj@immanuel.co)**