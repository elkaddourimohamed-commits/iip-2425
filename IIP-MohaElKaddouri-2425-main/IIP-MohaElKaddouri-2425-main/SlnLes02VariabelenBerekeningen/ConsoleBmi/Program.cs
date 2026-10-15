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
        }
    }
}
