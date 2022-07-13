using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Decorator.Interfaces.Services;
using Design.Patterns.Decorator.Models;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Core.Patterns
{
    public class Decorator : IPattern
    {
        private readonly IPsnPlusService _psnPlusService;

        public Decorator(IPsnPlusService psnPlusService)
        {
            _psnPlusService = psnPlusService;
        }

        public void Describe()
        {
            Console.WriteLine("Description:");
            var description = "The decorator pattern allows to extend behaviors and states of classes that cannot be inherited or when we don't want a strong coupling through inherit.";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }

        public void Execute()
        {
            Console.WriteLine("Example:");
            Console.WriteLine("Creating customers...");
            var will = new PsnCustomer("Will");
            var maria = new PsnCustomer("Maria");
            var jason = new PsnCustomer("Jason");

            Console.WriteLine("Subscribing the customers...");
            _psnPlusService.Subscribe(will, SubscriptionTier.Essential);
            _psnPlusService.Subscribe(maria, SubscriptionTier.Extra);
            _psnPlusService.Subscribe(jason, SubscriptionTier.Premium);

            Console.WriteLine("Upgrading customers subscriptions...");
            _psnPlusService.Upgrade(will);
            _psnPlusService.Upgrade(maria);
        }
    }
}
