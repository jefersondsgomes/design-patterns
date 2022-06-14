using Design.Patterns.ChainOfResponsability.Models.Enums;

namespace Design.Patterns.ChainOfResponsability.Models
{
    public class Order
    {
        public string? Id { get; private set; }
        public IList<Product> Products { get; private set; }
        public PaymentType PaymentType { get; private set; } = PaymentType.Card;

        public Order()
        {
            Id = Guid.NewGuid().ToString();
            Products = new List<Product>();
        }

        public void AddProduct(Product product) =>
            Products.Add(product);

        public void SetPaymentType(PaymentType paymentType) =>
            PaymentType = paymentType;
    }
}