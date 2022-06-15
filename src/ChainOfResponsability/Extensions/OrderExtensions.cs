using Design.Patterns.ChainOfResponsability.Models;

namespace Design.Patterns.ChainOfResponsability.Extensions
{
    public static class OrderExtensions
    {
        public static double GetValue(this Order order)
        {
            return order.Products.Sum(p => p.Value);
        }
    }
}