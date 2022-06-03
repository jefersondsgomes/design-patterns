using Design.Patterns.Builder.Models;

namespace Design.Patterns.Builder.Interfaces.Builders
{
    public interface IPersonalComputerBuilder
    {
        IPersonalComputerBuilder AddProcessor(Processor processor);
        IPersonalComputerBuilder AddMotherBoard(MotherBoard motherBoard);
        IPersonalComputerBuilder AddMemory(Memory memory);
        IPersonalComputerBuilder AddMemories(IList<Memory> memories);
        IPersonalComputerBuilder AddStorage(Storage storage);
        IPersonalComputerBuilder AddStorages(IList<Storage> storages);
        IPersonalComputerBuilder AddGraphicCard(GraphicCard graphicCard);
        IPersonalComputerBuilder AddPower(Power power);
        PersonalComputer Build();
    }
}