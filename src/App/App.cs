using Design.Patterns.Core.Interfaces.Resolvers;

namespace Design.Patterns.App
{
    public class App : BackgroundService
    {
        private readonly IPatternResolver _resolver;

        public App(IPatternResolver resolver)
        {
            _resolver = resolver;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new NotImplementedException();
        }
    }
}