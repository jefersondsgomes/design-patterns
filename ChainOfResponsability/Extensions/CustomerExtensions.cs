using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Extensions
{
    public static class CustomerExtensions
    {
        public static bool IsNew(this Customer customer)
        {
            if (customer?.Created == null)
                return false;

            return customer.Created.Value.Month <= 1;
        }

        public static bool ItsOver3Years(this Customer customer)
        {
            if (customer?.Created == null)
                return false;

            return customer.Created.Value.Year > 3;
        }
    }
}