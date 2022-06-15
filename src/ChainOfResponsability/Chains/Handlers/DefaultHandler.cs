using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Chains.Handlers
{
    public class DefaultHandler : IDiscountHandler
    {
        public IDiscountHandler NextDiscount => null!;
        public bool IsCumulative => false;

        public double Discount(Customer customer, Order order, double discount) =>
            discount;
    }
}