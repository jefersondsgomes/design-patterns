namespace Design.Patterns.Builder.Models
{
    public class PersonalComputer
    {
        public Processor? Processor { get; set; }
        public MotherBoard? MotherBoard { get; set; }
        public IList<Memory>? Memories { get; set; }
        public IList<Storage>? Storages { get; set; }
        public GraphicCard? GraphicCard { get; set; }
        public Power? Power { get; set; }
    }
}