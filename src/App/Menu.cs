using Design.Patterns.Core.Models.Enums;

namespace Design.Patterns.App
{
    public static class Menu
    {
        public static PatternKind Show()
        {
            Console.WriteLine("--- DESIGN PATTERNS ---");
            Console.WriteLine("1 - Builder");
            Console.WriteLine("2 - Chain Of Responsability");
            Console.WriteLine("3 - Decorator");
            Console.WriteLine("4 - Observer");
            Console.WriteLine("5 - State");
            Console.WriteLine("6 - Strategy");
            Console.WriteLine("7 - Template Method");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Select a design pattern:");

            var pattern = default(PatternKind);
            var option = Console.ReadKey().KeyChar;
            if (!Enum.TryParse(option.ToString(), out pattern))
            {
                Console.Clear();
                Show();
            }

            return pattern;
        }
    }
}