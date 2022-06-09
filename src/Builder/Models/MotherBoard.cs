using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class MotherBoard : Hardware
    {
        public ProcessorSocket Socket { get; set; }
        public FormFactor FormFactor { get; set; }
        public short MemorySlots { get; set; }

        public MotherBoard(string name, Brand brand) : base(name, brand)
        {

        }
    }
}