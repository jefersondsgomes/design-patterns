using Design.Patterns.Observer.Interfaces.Subjects;
using Design.Patterns.Observer.Models;
using System.Collections.ObjectModel;

namespace Design.Patterns.Observer.Subjects
{
    public class Subject : ISubject
    {
        private ICollection<User> _users;

        public Subject()
        {
            _users = new Collection<User>();
        }

        public void Attach(User user) =>
            _users.Add(user);

        public void Detach(User user) =>
            _users.Remove(user);

        public void Notify(NewsLetter newsLetter)
        {
            foreach (var user in _users)
            {

            }
        }
    }
}