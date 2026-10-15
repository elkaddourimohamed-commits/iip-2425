using System.Text;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($@"
WELKOM IN HET BUFFETRESTAURANT
==============================");
            Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen!");
            Console.WriteLine("!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");
            const double seizoensbuffet = 18.5;
            const double dessertenbuffet = 7.95;
            const double kidsmenus = 8.95;
            Console.ResetColor();
            Console.Write("Aantal seizoensbuffets (€18.5): ");
            string aantalseizoen = Console.ReadLine();
            int aantalseizoensbuffets = Convert.ToInt32(aantalseizoen);
            Console.Write("Aantal dessertenbuffets (€7.95): ");
            string aantaldessert = Console.ReadLine();
            int aantaldessertenbuffets = Convert.ToInt32(aantaldessert);
            Console.Write("Aantal kids menus (€8.95): ");
            string aantalkids = Console.ReadLine();
            int aantalkidsmenus = Convert.ToInt32(aantalkids);
            Console.WriteLine();
            Console.Write("Fooi (0 indien geen): ");
            string aantalfooi = Console.ReadLine();
            double aantalfooieuro = Convert.ToDouble(aantalfooi);
            double totaalbetalen = seizoensbuffet * aantalseizoensbuffets + dessertenbuffet * aantaldessertenbuffets + kidsmenus * aantalkidsmenus + aantalfooieuro;
            Console.WriteLine($"Totaal te betalen: {totaalbetalen}");
            double afgerondtotaal = Math.Floor(totaalbetalen);
            Console.WriteLine($"Afgerond naar beneden: {afgerondtotaal}");
            Console.WriteLine();
            Console.Write("Cash betaald: ");
            string betaling = Console.ReadLine();
            int cashbetaling = Convert.ToInt32(betaling);
            Console.WriteLine("U krijgt terug: ");
            double wisselgeld = cashbetaling - afgerondtotaal;
            int wisselgeldafgerond = Convert.ToInt32(wisselgeld);
            int vijftigwisselgeld = wisselgeldafgerond / 50;
            int restvijftig = wisselgeldafgerond % 50;
            Console.WriteLine($"{vijftigwisselgeld} briefje(s) van 50 terug ");
            int twintigwisselgeld = restvijftig / 20;
            int resttwintig = restvijftig % 20;
            Console.WriteLine($"{twintigwisselgeld} briefje(s) van 20 terug");
            int tienwisselgeld = resttwintig / 10;
            int resttien = resttwintig % 10;
            Console.WriteLine($"{tienwisselgeld} briefje(s) van 10 terug");
            int vijfwisseldgeld = resttien / 5;
            int restvijf = resttien % 5;
            Console.WriteLine($"{vijfwisseldgeld} briefje(s) van 5 terug");
            int tweewisselgeld = restvijf / 2;
            int resttwee = restvijf % 2;
            Console.WriteLine($"{tweewisselgeld} stuk(ken) van 2");
            int eenwisselgeld = resttwee / 1;
            int resteen = resttwee % 1;
            Console.WriteLine($"{eenwisselgeld} stuk(ken) van 1");
        }
    }
}
