namespace Design.Patterns.ChainOfResponsability.Models
{
    public class Customer
    {
        public string? Id { get; private set; }
        public DateTime? Created { get; private set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        private IList<Order> Orders { get; set; }

        public Customer(string name, DateTime? birthDate, DateTime? registrationDate = null)
        {
            Id = Guid.NewGuid().ToString();
            Created = registrationDate ?? DateTime.UtcNow;
            Name = name;
            BirthDate = birthDate;
            Orders = new List<Order>();
        }
    }
}