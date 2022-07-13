using Design.Patterns.Decorator.Interfaces.Components;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Components
{
    public abstract class PsnPlusSubscription : IPsnPlusSubscription
    {
        public SubscriptionTier Tier { get; protected set; }
        public double Price { get; protected set; }
        public List<string> Benefits { get; protected set; } = new List<string>
        {
            "Monthly games",
            "Online multiplayer",
            "Exclusive discounts",
            "Exclusive content",
            "Cloud storage",
            "Share Play",
            "PlayStation Plus Collection",
            "Game Help"
        };

        public PsnPlusSubscription()
        {

        }

        public PsnPlusSubscription(IPsnPlusSubscription subscription)
        {

        }

        public abstract IPsnPlusSubscription Upgrade();
    }
}