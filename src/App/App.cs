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
            var patternKind = Menu.Show();
            var pattern = _resolver.Resolve(patternKind);

            pattern.Describe();
            pattern.Execute();

            Environment.Exit(0);
            return Task.CompletedTask;
        }
    }
}