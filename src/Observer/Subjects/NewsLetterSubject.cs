using Design.Patterns.Observer.Interfaces.Observers;
using Design.Patterns.Observer.Interfaces.Subjects;
using Design.Patterns.Observer.Models;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Subjects
{
    public class NewsLetterSubject : ISubject
    {
        private readonly NewsLetter _newsLetter;
        private ICollection<IObserver> _observers;

        public NewsLetterSubject(NewsLetter newsLetter)
        {
            _newsLetter = newsLetter;
            _observers = new Collection<IObserver>();
        }

        public void Attach(IObserver observer) =>
            _observers.Add(observer);

        public void Detach(IObserver observer) =>
            _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Send(_newsLetter?.Subject!);
            }
        }
    }
}