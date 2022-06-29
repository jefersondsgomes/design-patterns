using Design.Patterns.Observer.Interfaces.Observers;
using Design.Patterns.Observer.Models.Enums;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Observers
{
    public class User : IObserver
    {
        public string? Name { get; set; }

        public readonly ICollection<ChannelKind> SubscribedChannels;

        public User(string name)
        {
            Name = name;
            SubscribedChannels = new Collection<ChannelKind>();
        }

        public void Subscribe(ChannelKind channel) =>
            SubscribedChannels.Add(channel);

        public void Update()
        {
            foreach (var channel in SubscribedChannels)
                Console.WriteLine($"Sending newsletter for {Name} by {channel}");
        }
    }
}