using System.Text;

namespace ConsoleAbonnement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($@"  
Bestelgegevens
==============");
            Console.Write("- naam klant: ");
            string naam = Console.ReadLine();
            Console.Write("");
            Console.Write("- aantal toegangsbeurten: ");
            string toegangsbeurt = Console.ReadLine();
            int toegang = Convert.ToInt32(toegangsbeurt);
            Console.Write("- prijs b.v. 122,5): ");
            string prijs = Console.ReadLine();
            double prijsdouble = Convert.ToDouble(prijs);
            Console.Write("- badkledij inbegrepen (typ true of false): ");
            string badkledij = Console.ReadLine();
            bool badofniet = Convert.ToBoolean(badkledij);
            Console.Write("- geslacht (druk 'm' of 'v'): ");
            string geslacht = Console.ReadLine();
            char type = Convert.ToChar(geslacht);
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($@"
Samenvatting
==============");
            Console.WriteLine($"- houder: {naam}");
            Console.WriteLine($"- geslacht: {type}");
            Console.WriteLine($"- prijs: €{prijsdouble:F1} "); 
            Console.WriteLine($"- aantal beurten: {toegang}");
            Console.WriteLine($"- incl. badkledij: {badofniet}");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("druk op een toets om verder te gaan...");
        }
    }
}
