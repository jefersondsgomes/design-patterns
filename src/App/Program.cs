using Design.Patterns.App;
using Design.Patterns.App.Extensions;

var pattern = Menu.Show();

IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices(services => services.ConfigureDependencyInjection().AddHostedService<App>())
    .Build();

host.Run();