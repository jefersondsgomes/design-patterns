using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Interfaces.Services;
using Design.Patterns.Decorator.Models;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Services
{
    public class PsnPlusService : IPsnPlusService
    {
        private readonly IEnumerable<IPsnPlusSubscription> _subscriptions;

        public PsnPlusService(IEnumerable<IPsnPlusSubscription> subscriptions)
        {
            _subscriptions = subscriptions;
        }

        public void Subscribe(PsnCustomer customer, SubscriptionTier tier)
        {
            ArgumentNullException.ThrowIfNull(nameof(customer));
            var subscription = _subscriptions.First(s => s.Tier == tier);
            customer.Subscription = subscription;
        }

        public void Upgrade(PsnCustomer customer)
        {
            ArgumentNullException.ThrowIfNull(nameof(customer));
            customer.Subscription = customer.Subscription?.Upgrade();
        }
    }
}