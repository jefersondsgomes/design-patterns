using Design.Patterns.Builder.Models;

namespace Design.Patterns.Builder.Interfaces.Builders
{
    public interface IPersonalComputerBuilder
    {
        IPersonalComputerBuilder AddProcessor(Processor processor);
        IPersonalComputerBuilder AddMotherBoard(MotherBoard motherBoard);
        IPersonalComputerBuilder AddMemory(Memory memory);
        IPersonalComputerBuilder AddMemories(IEnumerable<Memory> memories);
        IPersonalComputerBuilder AddStorage(Storage storage);
        IPersonalComputerBuilder AddStorages(IEnumerable<Storage> storages);
        IPersonalComputerBuilder AddGraphicCard(GraphicCard graphicCard);
        IPersonalComputerBuilder AddPowerSupply(PowerSupply power);
        PersonalComputer Build();
    }
}