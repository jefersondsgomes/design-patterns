using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Interfaces.Components
{
    public interface IPsnPlusSubscription
    {
        SubscriptionTier Tier { get; }
        double Price { get; }
        List<string> Benefits { get; }

        IPsnPlusSubscription Upgrade();
    }
}