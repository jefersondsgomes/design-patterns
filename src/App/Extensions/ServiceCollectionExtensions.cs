using Design.Patterns.Builder.Builders;
using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Core.Interfaces.Resolvers;
using Design.Patterns.Core.Resolvers;

namespace Design.Patterns.App.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDependencyInjection(this IServiceCollection services)
        {
            services
                .AddSingleton<IPatternResolver, PatternResolver>()
                .AddSingleton<IPattern, Core.Patterns.Builder>()
                .AddSingleton<IPersonalComputerBuilder, PersonalComputerBuilder>();

            return services;
        }
    }
}