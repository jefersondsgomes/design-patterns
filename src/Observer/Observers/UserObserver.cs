using Design.Patterns.Observer.Interfaces.Observers;
using Design.Patterns.Observer.Models.Enums;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Observers
{
    public class UserObserver : IObserver
    {
        public string? Name { get; set; }

        public readonly ICollection<ChannelKind> SubscribedChannels;

        public UserObserver(string name)
        {
            Name = name;
            SubscribedChannels = new Collection<ChannelKind>();
        }

        public void Subscribe(ChannelKind channel) =>
            SubscribedChannels.Add(channel);

        public void Send(string subject)
        {
            foreach (var channel in SubscribedChannels)
            {
                Console.WriteLine($"Sending '{subject}' for user {Name} by {channel}");
            }
        }
    }
}