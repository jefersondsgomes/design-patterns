using Design.Patterns.Observer.Interfaces.Observers;
using Design.Patterns.Observer.Interfaces.Subjects;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Subjects
{
    public abstract class AbstractSubject : ISubject
    {
        private ICollection<IObserver> _observers = new Collection<IObserver>();

        public virtual void Attach(IObserver observer) =>
            _observers.Add(observer);

        public virtual void Detach(IObserver observer) =>
            _observers?.Remove(observer);

        protected virtual void Notify()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}