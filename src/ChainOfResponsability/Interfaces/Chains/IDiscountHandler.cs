using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Interfaces.Chains
{
    public interface IDiscountHandler
    {
        IDiscountHandler NextDiscount { get; }
        bool IsCumulative { get; }
        double Discount(Customer customer, Order order, double discount);
    }
}