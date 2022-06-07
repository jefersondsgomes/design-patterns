using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder.Models
{
    public class Storage : Hardware
    {
        public short Capacity { get; set; }
        public StorageType Type { get; set; }

        public Storage(string name, Brand brand) : base(name, brand)
        {

        }
    }
}