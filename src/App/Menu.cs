using Design.Patterns.Core.Models.Enums;

namespace Design.Patterns.App
{
    public static class Menu
    {
        public static PatternKind Show()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------- DESIGN PATTERNS ---------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Builder");
            Console.WriteLine("2 - Chain Of Responsability");
            Console.WriteLine("3 - Decorator");
            Console.WriteLine("4 - Observer");
            Console.WriteLine("5 - State");
            Console.WriteLine("6 - Strategy");
            Console.WriteLine("7 - Template Method");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Select a design pattern:");
            Console.WriteLine(Environment.NewLine);

            var option = Console.ReadKey().KeyChar;
            if (!Enum.TryParse<PatternKind>(option.ToString(), out var pattern))
            {
                Console.Clear();
                Show();
            }

            Console.WriteLine($" - Selected pattern: {pattern}");
            Console.WriteLine(Environment.NewLine);
            return pattern;
        }
    }
}