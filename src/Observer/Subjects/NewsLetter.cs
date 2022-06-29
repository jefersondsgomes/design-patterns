using Design.Patterns.Observer.Models.Enums;

namespace Design.Patterns.Observer.Subjects
{
    public class NewsLetter : AbstractSubject
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public Status Status { get; private set; }

        public NewsLetter()
        {
            Status = Status.New;
        }

        public void SetAsWritten() =>
            Status = Status.Writed;

        public void Publish()
        {
            if (string.IsNullOrEmpty(Title))
                throw new Exception("Title cannot be null or empty");

            if (string.IsNullOrEmpty(Content))
                throw new Exception("Content cannot be null or empty");

            if (Status != Status.Writed)
                throw new Exception("A newsletter can only be published when it is written");

            Status = Status.Published;
            Notify();
        }
    }
}