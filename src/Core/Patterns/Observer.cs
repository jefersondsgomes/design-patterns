using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Observer.Models.Enums;
using Design.Patterns.Observer.Observers;
using Design.Patterns.Observer.Subjects;

namespace Design.Patterns.Core.Patterns
{
    public class Observer : IPattern
    {
        public void Describe()
        {
            Console.WriteLine("Description:");
            var description = "Provide an interface to notify observers when an object state is changed.";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }

        public void Execute()
        {
            Console.WriteLine("Example:");
            Console.WriteLine("Creating observers...");
            var jake = new User("Jake");
            jake.Subscribe(ChannelKind.Email);
            jake.Subscribe(ChannelKind.Push);

            var oleksandr = new User("Oleksandr");
            oleksandr.Subscribe(ChannelKind.Email);
            oleksandr.Subscribe(ChannelKind.Push);
            oleksandr.Subscribe(ChannelKind.WhatsApp);

            var gabriel = new User("Gabriel");
            gabriel.Subscribe(ChannelKind.Email);

            Console.WriteLine("Creating newsletter...");
            var newsLetter = new NewsLetter();
            newsLetter.Title = "Tech NewsLetter - Observer Pattern";
            newsLetter.Content = "Let's talk about observer pattern in C#!";
            newsLetter.SetAsWritten();

            Console.WriteLine("Adding users on newsletter...");
            newsLetter.Attach(jake);
            newsLetter.Attach(oleksandr);
            newsLetter.Attach(gabriel);

            // Users will be notified when newsletter is published
            Console.WriteLine("Publishing newsletter...");            
            newsLetter.Publish();
        }
    }
}