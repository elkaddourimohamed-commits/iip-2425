using System.ComponentModel;

namespace ConsolePaswoordenSorteren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // array van wachtwoorden
            string[] paswoorden = { "klepketoe", "test", "Azerty123", "rogier@work", "password", "MisterNasty12", "pwnz0red" };

            // ok en niet ok wachtwoorden
            List<string> okPaswoorden = new List<string>();
            List<string> nietOkPaswoorden = new List<string>();

            // sorteer ok en niet ok lijsten
            foreach (string paswoord in paswoorden)
            {
                if (IsCorrectPaswoord(paswoord))
                {
                    okPaswoorden.Add(paswoord);
                }
                else
                {
                    nietOkPaswoorden.Add(paswoord);
                }
            }

            // wachtwoorden
            Console.WriteLine("Alle paswoorden:");
            for (int i = 0; i < paswoorden.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {paswoorden[i]}");
            }

            // resultaten 
            Console.WriteLine();
            Console.WriteLine("Ok: " + string.Join(", ", okPaswoorden));
            Console.WriteLine("Niet ok: " + string.Join(", ", nietOkPaswoorden));
        }
        static bool IsCorrectPaswoord(string paswoord)
        {
            // minimumlengte is 8
            if (paswoord.Length < 8)
            {
                return false;
            }

            // mag geen @ bevatten
            if (paswoord.Contains('@'))
            {
                return false;
            }
            if (paswoord == "password" || paswoord == "Azerty123" || paswoord == "123456789")
            {
                return false;
            }

            return true;
        }
    }
}
