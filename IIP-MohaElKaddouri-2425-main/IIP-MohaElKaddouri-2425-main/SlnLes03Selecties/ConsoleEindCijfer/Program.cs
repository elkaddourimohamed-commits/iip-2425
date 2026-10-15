using System;

namespace ConsoleEindCijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Berekening eindcijfer
=====================");
            
            Console.Write("Geef het cijfer op dagelijks werk (op 20): ");
            double dagelijkswerk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20): ");
            double project = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20): ");
            double examen = Convert.ToDouble(Console.ReadLine());
            
            double eindcijfer = (dagelijkswerk * 0.30) + (project * 0.20) + (examen * 0.50);
            
            if (examen < 8)
            {
                eindcijfer = Math.Min(eindcijfer, examen);
            }
            
            double eindcijferpercent = eindcijfer * 5;
            
            eindcijferpercent = Math.Round(eindcijferpercent, 1);
           
            Console.WriteLine($"Je eindcijfer is {eindcijferpercent}%");
            
            if (eindcijferpercent < 50)
            {
                Console.WriteLine("-> onvoldoende");
            }
            else if (eindcijferpercent >= 50 && eindcijferpercent < 67.5)
            {
                Console.WriteLine("-> voldoende");
            }
            else if (eindcijferpercent >= 67.5 && eindcijferpercent < 75)
            {
                Console.WriteLine("-> onderscheiding");
            }
            else if (eindcijferpercent >= 75 && eindcijferpercent < 82.5)
            {
                Console.WriteLine("-> grote onderscheiding");
            }
            else
            {
                Console.WriteLine("-> grootste onderscheiding");
            }
        }
    }
}
