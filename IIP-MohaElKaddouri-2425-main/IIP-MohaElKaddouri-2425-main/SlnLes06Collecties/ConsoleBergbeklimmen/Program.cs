namespace ConsoleBergbeklimmen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lees hoogtes in tot een 0 wordt ingevoerd
            List<int> hoogtes = new List<int>();

            while (true)
            {
                Console.Write("Voer een hoogtemeting in (in m): ");
                int hoogte = int.Parse(Console.ReadLine());
                if (hoogte == 0)
                {
                    break;
                }
                hoogtes.Add(hoogte);
            }

            // bereken hoogteverschillen
            int[] stijgingen = BerekenStijgingen(hoogtes);

            // bepaal sterkste en totale stijging
            int sterksteStijging = BerekenSterksteStijging(stijgingen);
            int totaleStijging = BerekenTotaleStijging(stijgingen);

            // druk enkel de gevraagde resultaten af
            Console.WriteLine($"Stijgingen: {string.Join(", ", stijgingen)} meter"); 
            Console.WriteLine();
            Console.WriteLine($"De hoogste helling is {sterksteStijging} meter");
            Console.WriteLine($"De totale stijging is {totaleStijging} meter");
        }

        // bereken de stijgingen tussen opeenvolgende hoogtes
        static int[] BerekenStijgingen(List<int> hoogtes)
        {
            int[] verschillen = new int[hoogtes.Count - 1];
            for (int i = 0; i < hoogtes.Count - 1; i++)
            {
                verschillen[i] = hoogtes[i + 1] - hoogtes[i]; // Negeer dalingen
            }
            return verschillen;
        }

        // bepaal de sterkste (grootste) stijging
        static int BerekenSterksteStijging(int[] stijgingen)
        {
            int maxStijging = 0;
            foreach (int stijging in stijgingen)
            {
                if (stijging > maxStijging)
                {
                    maxStijging = stijging;
                }
            }
            return maxStijging;
        }

        // bepaal de totale stijging
        static int BerekenTotaleStijging(int[] stijgingen)
        {
            int totaleStijging = 0;
            foreach (int stijging in stijgingen)
            {
                if (stijging > 0) // negeer negatieve dalingen
                {
                    totaleStijging += stijging;
                }
            }
            return totaleStijging;
        }
    }
}