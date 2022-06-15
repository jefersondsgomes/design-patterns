using Design.Patterns.ChainOfResponsability.Extensions;
using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Chains.Handlers
{
    public class ValueHandler : IDiscountHandler
    {
        public IDiscountHandler NextDiscount { get; protected set; }
        public bool IsCumulative { get; protected set; }

        public ValueHandler(IDiscountHandler nextDiscount, bool isCumulative)
        {
            NextDiscount = nextDiscount;
            IsCumulative = isCumulative;
        }

        public double Discount(Customer customer, Order order, double discount)
        {
            var orderValue = order.GetValue();
            var currentDiscount = 0.0;

            if (orderValue > 1000)
                currentDiscount = 5.0;
            else if (orderValue > 500)
                currentDiscount = 2.0;

            if (IsCumulative)
            {
                currentDiscount += discount;
                return NextDiscount.Discount(customer, order, currentDiscount);
            }

            return currentDiscount;
        }
    }
}