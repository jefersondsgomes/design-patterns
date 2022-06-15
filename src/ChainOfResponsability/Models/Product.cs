namespace Design.Patterns.ChainOfResponsability.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public double Value { get; set; }

        public Product(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}