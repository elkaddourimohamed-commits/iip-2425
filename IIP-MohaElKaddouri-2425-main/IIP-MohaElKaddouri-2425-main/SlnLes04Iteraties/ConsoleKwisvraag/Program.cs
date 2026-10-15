namespace ConsoleKwisvraag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxPogingen = 3;
            int poging = 0;
            Console.WriteLine(@"
GROTE NAPOLEON KWISVRAAG
========================");
            Console.WriteLine("In welk jaar begon de Haïtiaanse Revolutie - 1789, 1791, 1804, 1815? Je krijgt drie pogingen");
            
            while (poging < maxPogingen)
            {
                Console.Write("Je antwoord: ");
                string antwoord = Console.ReadLine();
                if (antwoord == "1791")
                {
                    Console.WriteLine("Juist. Revolutionairen versloegen achtereenvolgens de Fransen, de Spanjaarden, de Britten en opnieuw de Fransen - deze keer onder Napoleon.");
                    Console.WriteLine($"Je hebt het gevonden in {poging + 1} poging(en)");
                    break;
                }
                switch (antwoord)
                {
                    case "1789":
                        Console.WriteLine("Fout. Dit is het jaar van de Franse Revolutie.");
                        poging++;
                        break;
                    case "1804":
                        Console.WriteLine("Fout. Dit is het jaar waarin Napoleon zich tot keizer kroonde.");
                        poging++;
                        break;
                    case "1815":
                        Console.WriteLine("Fout. Dit is het jaar dat Napoleon definitief verslagen werd bij Waterloo.");
                        poging++;
                        break;
                    default:
                        Console.WriteLine("Dit antwoord is niet geldig");
                        poging++;
                        break;
                }
                if (poging == maxPogingen)
                {
                    Console.WriteLine("Het juiste antwoord was 1971");
                }
            }
        }
    }
}
