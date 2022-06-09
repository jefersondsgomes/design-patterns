using Design.Patterns.Builder;
using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.Core.Interfaces.Patterns;

namespace Design.Patterns.Core.Patterns
{
    public class Builder : IPattern
    {
        private readonly IPersonalComputerBuilder _builder;

        public Builder(IPersonalComputerBuilder builder)
        {
            _builder = builder;
        }

        public void Describe()
        {
            Console.WriteLine("Description:");
            var description = "The Builder Pattern simplifies building complex objects through subdivision of his parts.";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }

        public void Execute()
        {
            Console.WriteLine("Example:");
            Console.WriteLine("Creating processor...");
            _builder.AddProcessor(HardwareVendor.ProvideProcessor());

            Console.WriteLine("Creating mother board...");
            _builder.AddMotherBoard(HardwareVendor.ProvideMotherBoard());

            Console.WriteLine("Creating memories...");
            _builder.AddMemories(HardwareVendor.ProvideMemories());

            Console.WriteLine("Creating storages...");
            _builder.AddStorages(HardwareVendor.ProvideStorages());

            Console.WriteLine("Creating graphic card...");
            _builder.AddGraphicCard(HardwareVendor.ProvideGraphicCard());

            Console.WriteLine("Creating power supply...");
            _builder.AddPowerSupply(HardwareVendor.ProvidePowerSupply());

            Console.WriteLine("Building personal computer...");
            _ = _builder.Build();
        }
    }
}