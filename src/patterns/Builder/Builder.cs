using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.Builder.Models;
using Design.Patterns.Builder.Models.Enums;
using Design.Patterns.Core.Interfaces;

namespace Design.Patterns.Builder
{
    public class Builder : IPattern
    {
        private readonly IPersonalComputerBuilder _builder;

        public Builder(IPersonalComputerBuilder builder)
        {
            _builder = builder;
        }

        public void Execute()
        {
            Console.WriteLine("BUILDER PATTERN");

            Console.WriteLine("Creating processor...");
            var processor = new Processor("AMD Ryzen 9", Brand.Amd)
            {
                Model = "5900X",
                Cores = 12,
                Speed = 3.7f
            };

            _builder.AddProcessor(processor);




            throw new NotImplementedException();
        }
    }
}