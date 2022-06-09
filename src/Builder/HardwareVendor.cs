using Design.Patterns.Builder.Models;
using Design.Patterns.Builder.Models.Enums;

namespace Design.Patterns.Builder
{
    public static class HardwareVendor
    {
        public static Processor ProvideProcessor()
        {
            return new Processor("Ryzen 9", Brand.Amd)
            {
                Model = "5900X",
                Cores = 12,
                Speed = 3.7f
            };
        }

        public static MotherBoard ProvideMotherBoard()
        {
            return new MotherBoard("TUF Gaming X570-PLUS", Brand.Asus)
            {
                FormFactor = FormFactor.ATX,
                MemorySlots = 4,
                Socket = ProcessorSocket.AM4
            };
        }

        public static IEnumerable<Memory> ProvideMemories()
        {
            var memory = new Memory("Fury Beast", Brand.HyperX)
            {
                Capacity = 8,
                Speed = 3000,
                Type = MemoryType.DDR4
            };

            return new List<Memory>().SelectMany(x => Enumerable.Repeat(memory, 4));
        }

        public static IEnumerable<Storage> ProvideStorages()
        {
            return new List<Storage>()
            {
                new Storage("WD Blue", Brand.WesternDigital)
                {
                    Capacity = 2,
                    Type = StorageType.HDD
                },
                new Storage("Kingston NV1", Brand.HyperX)
                {
                    Capacity = 1,
                    Type = StorageType.SSD
                }
            };
        }

        public static GraphicCard ProvideGraphicCard()
        {
            return new GraphicCard("GeForce RTX", Brand.Galax)
            {
                Model = "3060",
                Chipset = GpuChipset.Nvidia,
                MaxResolution = Resolution.UltraHD,
                MemoryCapacity = 12
            };
        }

        public static PowerSupply ProvidePowerSupply()
        {
            return new PowerSupply("EVGA 750W", Brand.EVGA)
            {
                Efficiency = EfficiencyLevel.Gold,
                Modularity = ModularType.Full
            };
        }
    }
}