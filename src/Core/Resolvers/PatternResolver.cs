using Design.Patterns.Core.Interfaces.Patterns;
using Design.Patterns.Core.Interfaces.Resolvers;
using Design.Patterns.Core.Models.Enums;

namespace Design.Patterns.Core.Resolvers
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
            switch (pattern)
            {
                case PatternKind.Builder:
                    return _patterns.SingleOrDefault(x => x.GetType().Equals(typeof(Patterns.Builder)))!;
                case PatternKind.ChainOfResponsability:
                    return _patterns.SingleOrDefault(x => x.GetType().Equals(typeof(Patterns.ChainOfResponsability)))!;
                case PatternKind.Observer:
                    return _patterns.SingleOrDefault(x => x.GetType().Equals(typeof(Patterns.Observer)))!;
                default:
                    throw new NotImplementedException(pattern.ToString());
            }
        }
    }
}