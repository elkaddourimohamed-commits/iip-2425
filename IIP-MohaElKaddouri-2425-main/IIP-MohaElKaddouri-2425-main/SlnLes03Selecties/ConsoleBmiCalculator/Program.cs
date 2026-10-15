using System.Drawing;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"
BMI CALCULATOR
==============");
            Console.Write("Lengte (in cm): ");
            string lengte = Console.ReadLine();
            int cm = Convert.ToInt32(lengte);
            Console.Write("Gewicht (in kg): ");
            string gewicht = Console.ReadLine();
            int kg = Convert.ToInt32(gewicht);
            double lengteM = Convert.ToDouble(cm) / 100;
            double lengteMkwadraat = lengteM * lengteM;
            double bmi = kg / lengteMkwadraat;
            double afgerondebmi = Convert.ToDouble(Math.Round(bmi, 1));
            Console.WriteLine($"Je BMI bedraagt: {afgerondebmi}");
            if (afgerondebmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Je hebt ondergewicht");
            }
            if (afgerondebmi >= 18.5 && afgerondebmi > 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Je gewicht is normaal");
            }
            if (afgerondebmi <= 25 && afgerondebmi > 30)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Je hebt overgewicht");
            }
            if (afgerondebmi >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Je hebt obesitas");
            }
}
    }
}
