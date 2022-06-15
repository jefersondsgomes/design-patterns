using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;
using Design.Patterns.ChainOfResponsability.Models.Enums;

namespace Design.Patterns.ChainOfResponsability.Chains.Handlers
{
    public class PaymentHandler : IDiscountHandler
    {
        public IDiscountHandler NextDiscount { get; protected set; }
        public bool IsCumulative { get; protected set; }

        public PaymentHandler(IDiscountHandler nextDiscount, bool isCumulative)
        {
            NextDiscount = nextDiscount;
            IsCumulative = isCumulative;
        }

        public double Discount(Customer customer, Order order, double discount)
        {
            var currentDiscount = order.PaymentType == PaymentType.Cash ? 5.0 : 0.0;

            if (IsCumulative)
            {
                currentDiscount += discount;
                return NextDiscount.Discount(customer, order, currentDiscount);
            }

            return currentDiscount;
        }
    }
}