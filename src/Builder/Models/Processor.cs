using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class Processor : Hardware
    {
        public string? Model { get; set; }
        public float Speed { get; set; }
        public short Cores { get; set; }

        public Processor(string name, Brand brand) : base(name, brand)
        {

        }
    }
}