using Design.Patterns.Core.Interfaces;
using Design.Patterns.Core.Models;

namespace Design.Patterns.Core
{
    public class PatternResolver : IPatternResolver
    {
        private readonly IEnumerable<IPattern> _patterns;

        public PatternResolver(IEnumerable<IPattern> patterns)
        {
            _patterns = patterns;
        }

        public IPattern Resolve(PatternKind pattern)
        {
            throw new NotImplementedException();
        }
    }
}