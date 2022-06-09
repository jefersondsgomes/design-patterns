using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Core.Models.Enums;

namespace Design.Patterns.Core.Interfaces.Resolvers
{
    public interface IPatternResolver
    {
        IPattern Resolve(PatternKind pattern);
    }
}