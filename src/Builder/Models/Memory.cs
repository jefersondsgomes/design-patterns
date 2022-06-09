using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class Memory : Hardware
    {
        public short Capacity { get; set; }
        public MemoryType Type { get; set; }
        public short Speed { get; set; }

        public Memory(string name, Brand brand) : base(name, brand)
        {

        }
    }
}