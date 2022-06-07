using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class GraphicCard : Hardware
    {
        public string? Model { get; set; }
        public GpuChipset Chipset { get; set; }
        public short MemoryCapacity { get; set; }
        public Resolution MaxResolution { get; set; }

        public GraphicCard(string name, Brand brand) : base(name, brand)
        {

        }
    }
}