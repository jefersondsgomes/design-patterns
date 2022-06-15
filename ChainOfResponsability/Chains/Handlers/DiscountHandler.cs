using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Chains.Handlers
{
    public class DiscountHandler : IDiscountHandler
    {
        public IDiscountHandler NextDiscount { get; protected set; }
        public bool IsCumulative { get; protected set; }

        public DiscountHandler(IDiscountHandler nextDiscount, bool isCumulative)
        {
            NextDiscount = nextDiscount;
            IsCumulative = isCumulative;
        }

        public double Discount(Customer customer, Order order, double discount)
        {
            return NextDiscount.Discount(customer, order, discount);
        }
    }
}