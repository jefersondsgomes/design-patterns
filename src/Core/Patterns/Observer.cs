using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Observer.Models;
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
            var description = "";
            Console.WriteLine(description);
            Console.WriteLine(Environment.NewLine);
        }

        public void Execute()
        {
            Console.WriteLine("Example:");
            Console.WriteLine("Creating newsletter...");
            var newsLetter = new NewsLetter
            {
                Subject = "Tech NewsLetter - Observer Pattern",
                Content = "Let's talk about observer pattern in C#!"
            };

            Console.WriteLine("Creating newsletter subject...");
            var observerNewsLetter = new NewsLetterSubject(newsLetter);

            Console.WriteLine("Creating users...");
            var jake = new UserObserver("Jake");
            jake.Subscribe(ChannelKind.Email);
            jake.Subscribe(ChannelKind.Push);

            var oleksandr = new UserObserver("Oleksandr");
            oleksandr.Subscribe(ChannelKind.Email);
            oleksandr.Subscribe(ChannelKind.Push);
            oleksandr.Subscribe(ChannelKind.WhatsApp);

            var gabriel = new UserObserver("Gabriel");
            gabriel.Subscribe(ChannelKind.Email);

            Console.WriteLine("Adding users on newsletter...");
            observerNewsLetter.Attach(jake);
            observerNewsLetter.Attach(oleksandr);
            observerNewsLetter.Attach(gabriel);

            Console.WriteLine("Notifying users...");
            observerNewsLetter.Notify();
        }
    }
}