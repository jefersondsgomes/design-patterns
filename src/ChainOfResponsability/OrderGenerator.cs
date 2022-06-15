using Design.Patterns.ChainOfResponsability.Models;
using Design.Patterns.ChainOfResponsability.Models.Enums;

namespace Design.Patterns.ChainOfResponsability
{
    public static class OrderGenerator
    {
        public static Order StationaryOrder()
        {
            var order = new Order();
            order.AddProduct(new Product("Pen", 0.8));
            order.AddProduct(new Product("Book", 3.0));
            order.AddProduct(new Product("Schoolbag", 23.0));
            order.AddProduct(new Product("Calculator", 5.0));
            order.AddProduct(new Product("Ink", 7.0));

            order.SetPaymentType(PaymentType.Cash);

            return order;
        }

        public static Order GameOrder()
        {
            var order = new Order();
            order.AddProduct(new Product("Elden Ring", 50.0));
            order.AddProduct(new Product("Crash Bandicoot 4 - It's About Time", 39.0));
            order.AddProduct(new Product("Counter-Strike Global Offensive", 0.0));
            order.AddProduct(new Product("Sony - PlayStation 5 - DualSense", 75.0));
            order.AddProduct(new Product("BenQ ZOWIE XL2540K 24.5", 450.0));

            order.SetPaymentType(PaymentType.Card);

            return order;
        }
    }
}