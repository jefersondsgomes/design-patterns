using Design.Patterns.App;
using Design.Patterns.App.Extensions;

IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices(services => services.ConfigureDependencyInjection().AddHostedService<App>())
    .Build();

host.Run();