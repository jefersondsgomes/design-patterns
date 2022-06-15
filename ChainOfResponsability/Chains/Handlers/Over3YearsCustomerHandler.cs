using Design.Patterns.ChainOfResponsability.Extensions;
using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Chains.Handlers
{
    public class Over3YearsCustomerHandler : IDiscountHandler
    {
        public IDiscountHandler NextDiscount { get; protected set; }
        public bool IsCumulative { get; protected set; }

        public Over3YearsCustomerHandler(IDiscountHandler nextDiscount, bool isCumulative)
        {
            NextDiscount = nextDiscount;
            IsCumulative = isCumulative;
        }

        public double Discount(Customer customer, Order order, double discount)
        {
            var currentDiscount = customer.ItsOver3Years() ? 5.0 : 0.0;

            if (IsCumulative)
            {
                currentDiscount += discount;
                return NextDiscount.Discount(customer, order, currentDiscount);
            }

            return currentDiscount;
        }
    }
}