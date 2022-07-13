using Design.Patterns.Decorator.Interfaces.Components;

namespace Design.Patterns.Decorator.Models
{
    public class PsnCustomer
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public IPsnPlusSubscription? Subscription { get; set; }

        public PsnCustomer(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }
    }
}