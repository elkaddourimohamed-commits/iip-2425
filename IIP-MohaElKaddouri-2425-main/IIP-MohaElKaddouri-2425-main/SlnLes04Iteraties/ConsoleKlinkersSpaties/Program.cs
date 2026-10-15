namespace ConsoleKlinkersSpaties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int klinkers = 0;
            int spaties = 0;
            string geheimschrift = "";

            foreach (char karakter in tekst)
            { 
                if ("aeiouAEIOU".Contains(karakter))
                {
                    klinkers++;
                }
                if (karakter == ' ')
                {
                    spaties++; 
                }
                if (char.IsLetter(karakter))
                {
                    char nieuweLetter = (char)(karakter + 1);
                    geheimschrift += nieuweLetter; 
                }
            }
            Console.WriteLine($"deze tekst bevat {klinkers} klinkers en {spaties} spaties");
            Console.WriteLine($"in geheimschrift: {geheimschrift}");
        }
    }
}
