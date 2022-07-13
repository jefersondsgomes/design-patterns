using Design.Patterns.Builder.Builders;
using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.ChainOfResponsability.Chains.Handlers;
using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Core.Interfaces.Resolvers;
using Design.Patterns.Core.Resolvers;
using Design.Patterns.Decorator.Decorators;
using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Interfaces.Services;
using Design.Patterns.Decorator.Services;

namespace Design.Patterns.App.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPatterns(this IServiceCollection services)
        {
            services
                .AddSingleton<IPatternResolver, PatternResolver>()
                .AddBuilder()
                .AddChainOfResponsability()
                .AddDecorator()
                .AddObserver();

            return services;
        }

        private static IServiceCollection AddBuilder(this IServiceCollection services)
        {
            services
                .AddSingleton<IPersonalComputerBuilder, PersonalComputerBuilder>()
                .AddSingleton<IPattern, Core.Patterns.Builder>();

            return services;
        }

        private static IServiceCollection AddChainOfResponsability(this IServiceCollection services)
        {
            services
                .AddSingleton(sp => new DefaultHandler())
                .AddSingleton(sp => new ValueHandler(sp.GetService<DefaultHandler>()!, true))
                .AddSingleton(sp => new PaymentHandler(sp.GetService<ValueHandler>()!, true))
                .AddSingleton(sp => new Over3YearsCustomerHandler(sp.GetService<PaymentHandler>()!, true))
                .AddSingleton(sp => new NewCustomerHandler(sp.GetService<Over3YearsCustomerHandler>()!, true))
                .AddSingleton<IDiscountHandler>(sp => new DiscountHandler(sp.GetService<NewCustomerHandler>()!, false))
                .AddSingleton<IPattern, Core.Patterns.ChainOfResponsability>();

            return services;
        }

        private static IServiceCollection AddDecorator(this IServiceCollection services)
        {
            services
                .AddSingleton<IPsnPlusSubscription>(sp => new PsnPlusEssential())
                .AddSingleton<IPsnPlusSubscription>(sp => new PsnPlusExtra(sp.GetService<PsnPlusEssential>()!))
                .AddSingleton<IPsnPlusSubscription>(sp => new PsnPlusPremium(sp.GetService<PsnPlusExtra>()!))
                .AddSingleton<IPsnPlusService, PsnPlusService>()
                .AddSingleton<IPattern, Core.Patterns.Decorator>();

            return services;
        }

        private static IServiceCollection AddObserver(this IServiceCollection services)
        {
            services
                .AddSingleton<IPattern, Core.Patterns.Observer>();

            return services;
        }
    }
}