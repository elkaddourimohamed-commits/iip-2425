namespace ConsoleContacten
{
    internal class Program
    {
        static List<string> contacten = new List<string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ToonContacten();
                Console.WriteLine("a. Contact toevoegen");
                Console.WriteLine("b. Contact wijzigen");
                Console.WriteLine("c. Contact verwijderen");
                Console.WriteLine("x. Afsluiten");
                Console.Write("Maak je keuze: ");
                string keuze = Console.ReadLine();
                switch (keuze)
                {
                    case "a": ContactToevoegen(); break;
                    case "b": ContactWijzigen(); break;
                    case "c": ContactVerwijderen(); break;
                    case "x": return;
                }
            }
        }
        static void ToonContacten()
        {
            Console.WriteLine(@"
CONTACTEN
=========");
            if (contacten.Count == 0)
            {
                Console.WriteLine("Je hebt nog geen contacten");
            }
            else
            {
                for (int i = 0; i < contacten.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{contacten[i]}");
                }
            }
        }
        static void ContactToevoegen()
        {
            Console.WriteLine("Naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Telefoonnummer: ");
            string nummer = Console.ReadLine();
            contacten.Add(naam + "-" + nummer);
        }
        static void ContactWijzigen()
        {
            if (contacten.Count == 0)
            {
                Console.WriteLine("Geen contacten om te wijzigen");
                return;
            }
            int index = VraagGetalTussen(1, contacten.Count) - 1;
        }
        static void ContactVerwijderen()
        {
            if (contacten.Count == 0)
            {
               Console.WriteLine("Geen contacten om te verwijderen");
               return;
            }
            int index = VraagGetalTussen(1, contacten.Count) - 1;
            contacten.RemoveAt(index);
        }
        static int VraagGetalTussen(int min, int max)
        {
            int getal;
            while (true)
            {
                Console.Write($"Selecteer een contact {min}-{max}");
                if (int.TryParse(Console.ReadLine(), out getal) && getal >= min && getal <= max)
                {
                    Console.WriteLine($"Het getal moet tussen {min} en {max} liggen");
                }
                return getal;
            }
        }
}
}
