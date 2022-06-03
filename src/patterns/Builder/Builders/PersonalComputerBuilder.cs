using Design.Patterns.Builder.Interfaces.Builders;
using Design.Patterns.Builder.Models;

namespace Design.Patterns.Builder.Builders
{
    public class PersonalComputerBuilder : IPersonalComputerBuilder
    {
        protected Processor? Processor { get; set; }
        protected MotherBoard? MotherBoard { get; set; }
        protected IList<Memory>? Memories { get; set; }
        protected IList<Storage>? Storages { get; set; }
        protected GraphicCard? GraphicCard { get; set; }
        protected Power? Power { get; set; }

        public PersonalComputerBuilder()
        {
            Memories = new List<Memory>();
            Storages = new List<Storage>();
        }

        public IPersonalComputerBuilder AddProcessor(Processor processor)
        {
            Processor = processor;
            return this;
        }

        public IPersonalComputerBuilder AddMotherBoard(MotherBoard motherBoard)
        {
            MotherBoard = motherBoard;
            return this;
        }

        public IPersonalComputerBuilder AddMemory(Memory memory)
        {
            Memories!.Add(memory);
            return this;
        }

        public IPersonalComputerBuilder AddMemories(IList<Memory> memories)
        {
            foreach (var memory in memories)
                Memories!.Add(memory);

            return this;
        }

        public IPersonalComputerBuilder AddStorage(Storage storage)
        {
            Storages!.Add(storage);
            return this;
        }

        public IPersonalComputerBuilder AddStorages(IList<Storage> storages)
        {
            foreach (var storage in storages)
                Storages!.Add(storage);

            return this;
        }

        public IPersonalComputerBuilder AddGraphicCard(GraphicCard graphicCard)
        {
            GraphicCard = graphicCard;
            return this;
        }

        public IPersonalComputerBuilder AddPower(Power power)
        {
            Power = power;
            return this;
        }

        public PersonalComputer Build()
        {
            return new PersonalComputer
            {
                Processor = Processor,
                MotherBoard = MotherBoard,
                Memories = Memories,
                Storages = Storages,
                GraphicCard = GraphicCard,
                Power = Power
            };
        }
    }
}