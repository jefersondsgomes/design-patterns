using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class PowerSupply : Hardware
    {
        public EfficiencyLevel Efficiency { get; set; }
        public ModularType Modularity { get; set; }

        public PowerSupply(string name, Brand brand) : base(name, brand)
        {

        }
    }
}