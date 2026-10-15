namespace ConsoleBankautomaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 500.00;
            while (true)
            {
                Console.WriteLine(@"
Bankautomaat
============");
           
                Console.WriteLine("a. afhaling");
                Console.WriteLine("b. storting");
                Console.WriteLine("c. stoppen");
               
                Console.Write("je keuze: ");
                string keuze = Console.ReadLine();
                if (keuze == "c")
                {
                    Console.WriteLine("Bedankt en tot ziens.");
                    break;
                }

                switch (keuze)
                {
                    case "a":
                        Console.Write("Welk bedrag wil je afhalen? ");
                        double afhaling = Convert.ToDouble(Console.ReadLine());
                        if (afhaling > saldo)
                        {
                            Console.WriteLine("onvoldoende saldo");
                        }
                        else
                        {
                            Console.WriteLine($"afhaling ok - het nieuwe saldo is {saldo -= afhaling}");
                        }
                        break;
                    case "b":
                        Console.Write("Welk bedrag wil je storten? ");
                        double storting = Convert.ToDouble(Console.ReadLine());
                        double nieuwsaldo = saldo += storting;
                        Console.WriteLine($"storting ok - het nieuwe saldo is {nieuwsaldo}");
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze");
                        break;
}
            }
        }
    }
}
