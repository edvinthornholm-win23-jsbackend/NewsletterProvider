//using Data.Contexts;
//using Microsoft.Azure.Functions.Worker;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Options;

//var host = new HostBuilder()
//    .ConfigureFunctionsWebApplication()
//    .ConfigureServices(services =>
//    {
//        services.AddApplicationInsightsTelemetryWorkerService();
//        services.ConfigureFunctionsApplicationInsights();
//        services.AddDbContext<DataContext>(x => x.UseSqlServer(Environment.GetEnvironmentVariable("SqlServer")));

//    })
//    .Build();

//host.Run();

using Data.Contexts;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddDbContext<DataContext>(x => x.UseSqlServer("Server=tcp:sqlserver-silicon-et.database.windows.net,1433;Initial Catalog=blazorwebapp;Persist Security Info=False;User ID=SqlAdmin;Password=A3jokrar!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

    })
    .Build();

host.Run();
