using Design.Patterns.Observer.Models;

namespace Design.Patterns.Observer.Interfaces.Subjects
{
    public interface ISubject
    {
        void Attach(User user);
        void Detach(User user);
        void Notify(NewsLetter newsLetter);
    }
}