namespace ConsoleGangsterName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"************************
| GANGSTA NAME BUILDER |
************************
");
            Console.Write("Give the first name of any Disney character: ");
            string disney = Console.ReadLine();
            Console.Write("Give any workbench tool: ");
            string voorwerp = Console.ReadLine();
            Console.Write("What is your last name: ");
            string naam = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("Your gangsta name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{disney} \"{voorwerp}\" {naam}");
        }
    }
}


