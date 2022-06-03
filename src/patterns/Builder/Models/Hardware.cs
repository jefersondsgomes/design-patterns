using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public abstract class Hardware
    {
        public string? Name { get; set; }
        public Brand Brand { get; set; }

        public Hardware(string name, Brand brand)
        {
            Name = name;
            Brand = brand;
        }
    }
}