using Design.Patterns.Observer.Models.Enums;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Models
{
    public class User
    {
        public string? Name { get; set; }

        private ICollection<Channel> SubscribedChannels;

        public User(string name)
        {
            Name = name;
            SubscribedChannels = new Collection<Channel>();
        }

        public void Subscribe(Channel channel) =>
            SubscribedChannels.Add(channel);
    }
}