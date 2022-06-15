using Design.Patterns.Builder.Builders;
using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.ChainOfResponsability.Chains.Handlers;
using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
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
                .AddPatterns()
                .AddBuilder()
                .AddChainOfResponsability();

            return services;
        }

        private static IServiceCollection AddPatterns(this IServiceCollection services)
        {
            services
                .AddSingleton<IPattern, Core.Patterns.Builder>()
                .AddSingleton<IPattern, Core.Patterns.ChainOfResponsability>();

            return services;
        }

        private static IServiceCollection AddBuilder(this IServiceCollection services)
        {
            services
                .AddSingleton<IPersonalComputerBuilder, PersonalComputerBuilder>();

            return services;
        }

        private static IServiceCollection AddChainOfResponsability(this IServiceCollection services)
        {
            services
                .AddSingleton(new DefaultHandler())
                .AddSingleton(sp => new ValueHandler(sp.GetService<DefaultHandler>()!, true))
                .AddSingleton(sp => new PaymentHandler(sp.GetService<ValueHandler>()!, true))
                .AddSingleton(sp => new Over3YearsCustomerHandler(sp.GetService<PaymentHandler>()!, true))
                .AddSingleton(sp => new NewCustomerHandler(sp.GetService<Over3YearsCustomerHandler>()!, true))
                .AddSingleton<IDiscountHandler>(sp => new DiscountHandler(sp.GetService<NewCustomerHandler>()!, false));

            return services;
        }
    }
}