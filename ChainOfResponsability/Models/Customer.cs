namespace Design.Patterns.ChainOfResponsability.Models
{
    public class Customer
    {
        public string? Id { get; private set; }
        public DateTime? Created { get; private set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        private IDictionary<int, Order> Orders { get; set; }

        public Customer(string name, DateTime? birthDate, DateTime? registrationDate = null)
        {
            Id = Guid.NewGuid().ToString();
            Created = registrationDate ?? DateTime.UtcNow;
            Name = name;
            BirthDate = birthDate;
            Orders = new Dictionary<int, Order>();
        }

        public void AddOrder(Order order) =>
            Orders.Add(Orders.Count + 1, order);

        public void AddOrders(IEnumerable<Order> orders)
        {
            foreach (var order in orders)
                AddOrder(order);
        }
    }
}