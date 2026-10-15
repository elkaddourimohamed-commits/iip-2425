namespace ConsoleRadenGrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__________    _____  ________  ___________ _______   \r\n\\______   \\  /  _  \\ \\______ \\ \\_   _____/ \\      \\  \r\n |       _/ /  /_\\  \\ |    |  \\ |    __)_  /   |   \\ \r\n |    |   \\/    |    \\|    `   \\|        \\/    |    \\\r\n |____|_  /\\____|__  /_______  /_______  /\\____|__  /\r\n        \\/         \\/        \\/        \\/         \\/ ");
            Console.WriteLine("Geef twee gehele getallen.");
            Console.Write("- getal 1: ");
            string ondergrensstring = Console.ReadLine();
            int ondergrens = Convert.ToInt32(ondergrensstring);
            Console.Write("- getal 2: ");
            string bovengrensstring = Console.ReadLine();
            int bovengrens = Convert.ToInt32(bovengrensstring);
            if (ondergrens > bovengrens)
            {
                int tmp = ondergrens;
                ondergrens = bovengrens;
                bovengrens = tmp;
            }
            Console.WriteLine($"Even denken... ja, ik heb een getal tussen {ondergrens} en {bovengrens} in mijn hood");
            Random rnd = new Random();
            int willekeurig = rnd.Next(ondergrens, bovengrens + 1);
            Console.Write("Doe een gok: ");
            string raden = Console.ReadLine();
            int gok = Convert.ToInt32(raden);
            if (gok == willekeurig)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JUIST");
            }
            else if (Math.Abs(gok - willekeurig) <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT");
                Console.ResetColor();
                Console.WriteLine("Je zat er nochtans niet ver van af!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FOUT");
            }
        }
    }
}
