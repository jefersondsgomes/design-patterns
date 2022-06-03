using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public abstract class Hardware
    {
        protected string? Name { get; set; }
        protected Brand Brand { get; set; }

        public Hardware(string name, Brand brand)
        {
            Name = name;
            Brand = brand;
        }
    }
}