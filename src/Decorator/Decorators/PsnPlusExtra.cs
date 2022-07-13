using Design.Patterns.Decorator.Components;
using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Decorators
{
    public sealed class PsnPlusExtra : PsnPlusSubscription
    {
        public PsnPlusExtra(IPsnPlusSubscription subscription) : base(subscription)
        {
            Tier = SubscriptionTier.Extra;
            Price = subscription.Price + 39.91;
            Benefits = subscription.Benefits;
            Benefits.AddRange(new List<string>
            {
                "Game Catalog",
                "Ubisoft+ Classics"
            });
        }

        public override IPsnPlusSubscription Upgrade()
        {
            return new PsnPlusPremium(this);
        }
    }
}