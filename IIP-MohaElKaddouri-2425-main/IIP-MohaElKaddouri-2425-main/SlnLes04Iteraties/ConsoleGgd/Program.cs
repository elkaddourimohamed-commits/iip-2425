namespace ConsoleGgd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
BEREKEN GROOTSTE GEMENE DELER
=============================");
            Console.Write("Getal 1: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            while (getal1 != getal2)
            {
                if (getal1 > getal2)
                {
                    getal1 -= getal2;
                }
                else
                {
                    getal2 -= getal1;
                }
            }
            Console.WriteLine($"\nDe grootste gemene deler is: {getal1}");
        }
    }
}
