using Design.Patterns.ChainOfResponsability;
using Design.Patterns.ChainOfResponsability.Interfaces.Chains;
using Design.Patterns.ChainOfResponsability.Models;
using Design.Patterns.Core.Interfaces.Patterns;

namespace Design.Patterns.Core.Patterns
{
    public class ChainOfResponsability : IPattern
    {
        private readonly IDiscountHandler _discountHandler;

        public ChainOfResponsability(IDiscountHandler discountHandler)
        {
            _discountHandler = discountHandler;
        }

        public void Describe()
        {
            Console.WriteLine("Description:");
            var description = "Chain of Responsibility allow a request to be chained until some class be able to return one result.";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }

        public void Execute()
        {
            Console.WriteLine("Example:");
            Console.WriteLine("Adding customer...");
            var customer = new Customer("Uncle Bob", new DateTime(1952, 10, 2), DateTime.Now.AddYears(-4));

            Console.WriteLine("Generating orders...");
            var firstOrder = OrderGenerator.StationaryOrder();
            var secondOrder = OrderGenerator.GameOrder();

            Console.WriteLine("Calculating discounts...");
            var firstOrderDiscount = _discountHandler.Discount(customer, firstOrder, 0);
            var secondOrderDiscount = _discountHandler.Discount(customer, secondOrder, 0);

            Console.WriteLine($"First order discount: {firstOrderDiscount}");
            Console.WriteLine($"Second order discount: {secondOrderDiscount}");

            Console.WriteLine("Adding orders to customer...");
            customer.AddOrder(firstOrder);
            customer.AddOrder(secondOrder);
        }
    }
}