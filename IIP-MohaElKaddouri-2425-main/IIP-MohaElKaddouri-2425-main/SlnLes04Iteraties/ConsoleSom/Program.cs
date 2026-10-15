namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer een getal in (q om te stoppen): ");
            string q = Console.ReadLine();
            double som = 0;

            while (q != "q")
            {
                double getal = Convert.ToDouble(q);
                som += getal;
                Console.Write("Voer een getal in (q om te stoppen): ");
                q = Console.ReadLine();
            }
            Console.WriteLine($"De som is: {som}");
            }
    }
}
