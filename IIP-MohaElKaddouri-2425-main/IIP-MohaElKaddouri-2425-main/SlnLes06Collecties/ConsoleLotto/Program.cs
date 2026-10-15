using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLotto
{
    class Program
    {
        const int MIN = 1;
        const int MAX = 42;
        const int TOTAALGETALLEN = 6;

        static void Main(string[] args)
        {
            // initialisatie arrays en lijsten
            int[] winnendeGetallen = { 4, 8, 17, 22, 31, 39, 41 };
            int[] ingevoerdeGetallen = new int[TOTAALGETALLEN];
            List<int> correcteGetallen = new List<int>();

            // welkom lottotrekking
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
WELKOM OP DE LOTTOTREKKING
==========================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();

            // cijfers vragen
            Console.Write("Voer 6 getallen tussen 1 en 42 gescheiden door spaties: ");
            string input = Console.ReadLine();

            // foutieve antwoord : random getallen
            if (string.IsNullOrEmpty(input))
            {
                ingevoerdeGetallen = GenereerGetallen(TOTAALGETALLEN, MIN, MAX);
            }
            else
            {
                string[] nummers = input.Split(' ');

                // nummer tussen 1 en 42
                for (int i = 0; i < TOTAALGETALLEN; i++)
                {
                    int nummer = int.Parse(nummers[i]);

                    // nummer nier tussen 1 en 42
                    while (nummer < MIN || nummer > MAX)
                    {
                        Console.WriteLine($"Foutief getal: {nummer}. Voer een getal in tussen {MIN} en {MAX}: ");
                        nummer = int.Parse(Console.ReadLine());
                    }

                    ingevoerdeGetallen[i] = nummer;
                }
            }

            // trekking
            foreach (int getal in ingevoerdeGetallen)
            {
                if (winnendeGetallen.Contains(getal))
                {
                    correcteGetallen.Add(getal);
                }
            }

            // résultaten
            Console.WriteLine("Trekking: " + string.Join(", ", winnendeGetallen));

            // gemeenschappelijke waarden
            List<int> gemeenschappelijkeGetallen = GemeenschappelijkeWaarden(winnendeGetallen, ingevoerdeGetallen);
            Console.WriteLine($"Je hebt {correcteGetallen.Count} juist: : " + string.Join(", ", gemeenschappelijkeGetallen));
        }

        // random getallen
        static int[] GenereerGetallen(int aantal, int min, int max)
        {
            Random rand = new Random();
            HashSet<int> getallenSet = new HashSet<int>();

            while (getallenSet.Count < aantal)
            {
                getallenSet.Add(rand.Next(min, max + 1));
            }

            return getallenSet.OrderBy(x => x).ToArray();
        }

        // methode voor gemeenschappelijke waarden
        static List<int> GemeenschappelijkeWaarden(int[] lijst1, int[] lijst2)
        {
            return lijst1.Intersect(lijst2).ToList();
        }
    }
}
