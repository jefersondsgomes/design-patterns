using Design.Patterns.Observer.Interfaces.Observers;

namespace Design.Patterns.Observer.Interfaces.Subjects
{
    public interface ISubject
    {
        void Attach(IObserver user);
        void Detach(IObserver user);
        void Notify();
    }
}