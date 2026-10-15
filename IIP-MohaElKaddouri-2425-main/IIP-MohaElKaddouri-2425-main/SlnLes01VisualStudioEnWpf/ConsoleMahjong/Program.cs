using System.Text;

namespace ConsoleMahjong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"************************
| GANGSTA NAME BUILDER |
************************
");
            Console.ResetColor();
            Console.Write("druk op een ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("willekeurige toets");
            Console.ResetColor();
            Console.Write(" om de steen te tonen...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("◉◉◉");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("◉◉◉");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("◉◉◉");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("druk op een toets om af te sluiten...");
        }
    }
}
