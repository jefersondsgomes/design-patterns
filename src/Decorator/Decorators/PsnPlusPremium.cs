using Design.Patterns.Decorator.Components;
using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Decorators
{
    public sealed class PsnPlusPremium : PsnPlusSubscription
    {
        public PsnPlusPremium(IPsnPlusSubscription subscription) : base(subscription)
        {
            Tier = SubscriptionTier.Premium;
            Price = subscription.Price + 20.09;
            Benefits = subscription.Benefits;
            Benefits.AddRange(new List<string>
            {
                "Classics Catalog",
                "Game trials",
                "Cloud streaming"
            });
        }

        public override IPsnPlusSubscription Upgrade()
        {
            Console.WriteLine("This is the last subscription tier");
            return this;
        }
    }
}