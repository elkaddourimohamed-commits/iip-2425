namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering? ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("for-versie:");
            for (int fori = i; fori >= 1; fori--)
            {
                Console.WriteLine($"{fori}...");
            }
            Console.WriteLine("Lift Off!");

            Console.WriteLine("do-while versie:");
            int doi = i;
            do
            {
                Console.WriteLine($"{doi}...");
                doi--;
            }
            while (doi >= 1);
            Console.WriteLine("Lift Off!");

            Console.WriteLine("while versie:");
            int whilei = i;
            while (whilei >= 1)
            {
                Console.WriteLine($"{whilei}...");
                whilei--;
            }
            Console.WriteLine("Lift Off!");
        }
}
}
