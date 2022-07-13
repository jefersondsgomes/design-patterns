using Design.Patterns.Decorator.Models;
using Design.Patterns.Decorator.Models.Enums;

namespace Design.Patterns.Decorator.Interfaces.Services
{
    public interface IPsnPlusService
    {
        void Subscribe(PsnCustomer customer, SubscriptionTier tier);
        void Upgrade(PsnCustomer customer);
    }
}