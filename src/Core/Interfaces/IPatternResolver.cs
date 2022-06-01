using Design.Patterns.Core.Models;

namespace Design.Patterns.Core.Interfaces
{
    public interface IPatternResolver
    {
        IPattern Resolve(PatternKind pattern);
    }
}