using Design.Patterns.Decorator.Components;
using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Decorators
{
    public sealed class PsnPlusEssential : PsnPlusSubscription
    {
        public PsnPlusEssential() : base()
        {
            Tier = SubscriptionTier.Essential;
            Price = 59.99;
        }

        public override IPsnPlusSubscription Upgrade()
        {
            return new PsnPlusExtra(this);
        }
    }
}