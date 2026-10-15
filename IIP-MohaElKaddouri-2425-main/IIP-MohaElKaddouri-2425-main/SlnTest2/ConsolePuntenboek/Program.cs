using System.Xml.Linq;

namespace ConsolePuntenboek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namenstudent = { "Matthias", "Ilyas", "Nadya", "Emmanuel" };
            int[] scoreportfolio = { 12, 12, 15, 6 };
            int[] scoreproject = { 14, 8, 11, 9 };
            Console.WriteLine(@"
PUNTENBOEK
==========");
            Console.WriteLine("Aantal studenten: 4");
            Console.WriteLine();
            for (int i = 0; i < namenstudent.Length; i++)
            {
                string naam = namenstudent[i];
                Console.WriteLine($"Student {i + 1}: {naam}");
            }
            for (int j = 0; j < scoreportfolio.Length; j++)
            {
                int portfolio = scoreportfolio[j];
                Console.WriteLine($"Score portfolio (op 20): {portfolio}");
            }
            for (int k = 0; k < scoreportfolio.Length; k++)
            {
                int project = scoreproject[k];
                Console.WriteLine($"Score project (op 20): {project}");
            }
            Console.WriteLine(@"
SCORES
======");
        }
        private static void BerekenEindscore(int portfolio, int project)
        {
            double eindscoreportfolio = (portfolio * 60) / 100;
            double eindscoreproject = (project * 40) / 100;
            double eindscore = (eindscoreportfolio + eindscoreproject) / 5;
        }
        private static void GenereerEindscoreLijst(double eindscore)
        {
            Console.WriteLine($"Matthias {eindscore.ToString("F1")}");
            Console.WriteLine($"Ilyas {eindscore.ToString("F1")}");
            Console.WriteLine($"Nadya {eindscore.ToString("F1")}");
            Console.WriteLine($"Emmanuel {eindscore.ToString("F1")}");
        }
        private static void BepaalGeslaagden(double eindscore, string naam)
        {
            if (eindscore > 10)
            {
                Console.WriteLine($"Geslaagd:  {naam}");
            }
        }
        private static void PrintEindscores(double eindscore)
        {
            if (eindscore > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}
