using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class Power : Hardware
    {
        public EfficiencyLevel Efficiency { get; set; }
        public ModularType Modularity { get; set; }

        public Power(string name, Brand brand) : base(name, brand)
        {

        }
    }
}