using Design.Patterns.Observer.Interfaces.Observers;

namespace Design.Patterns.Observer.Interfaces.Subjects
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}