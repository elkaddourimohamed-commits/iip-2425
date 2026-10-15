using System.Text;

namespace ConsoleJokerPlus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            const string schoppen = "♠";
            const string harten = "♡";
            const string ruiten = "♢";
            const string klaver = "♣";
            Console.WriteLine("     ____.________   ____  __._____________________             \r\n    |    |\\_____  \\ |    |/ _|\\_   _____/\\______   \\    .__     \r\n    |    | /   |   \\|      <   |    __)_  |       _/  __|  |___ \r\n/\\__|    |/    |    \\    |  \\  |        \\ |    |   \\ /__    __/ \r\n\\________|\\_______  /____|__ \\/_______  / |____|_  /    |__|    \r\n                  \\/        \\/        \\/         \\/             ");
            Console.WriteLine(@"
Welcome to JokerPlus! Kies vier getallen tussen 0 en 9 en een kaa
rtkleur. De bank zal een willekeurige combinatie trekken. Hoe mee
r cijfers je juist hebt op de juiste plaats, hoe meer je wint. Al
s je ook nog het sterrenbeeld juist hebt, win je de jackpot!");
            Console.WriteLine();
            Console.Write("Kies een getal van vier cijfers: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(@"
a. schoppen 
b. harten 
c. ruiten
d. klaver");
            Console.WriteLine();
            Console.Write("Kies nu een kaartkleur: ");
            string kaartkleur = Console.ReadLine();
            Console.WriteLine();
            switch (kaartkleur)
            {
                case "a":
                    Console.WriteLine($"Je hebt gekozen voor {getal} en {schoppen}");
                    break;
                case "b":
                    Console.WriteLine($"Je hebt gekozen voor {getal} en {harten}");
                    break;
                case "c":
                    Console.WriteLine($"Je hebt gekozen voor {getal} en {ruiten}");
                    break;
                case "d":
                    Console.WriteLine($"Je hebt gekozen voor {getal} en {klaver}");
                    break;
                default: Console.WriteLine($"Je hebt gekozen voor {getal} en {klaver}");
                    break;
            }
            Random rnd = new Random();
            int randomgetal = rnd.Next(1000, 10000);

            Random rnd2 = new Random();
            int randomkaart = rnd2.Next(9824, 9828);

            switch (randomkaart)
            {
                case 9824:
                    Console.WriteLine($"{schoppen}");
                    Console.WriteLine("De bank doet nu de trekking...");
                    Thread.Sleep(1000);
                    Console.WriteLine($"De bank heeft getrokken: {randomgetal} en {schoppen}");
                    break;
                case 9825:
                    Console.WriteLine($"{harten}");
                    Console.WriteLine("De bank doet nu de trekking...");
                    Thread.Sleep(1000);
                    Console.WriteLine($"De bank heeft getrokken: {randomgetal} en {harten}");
                    break;
                case 9826:
                    Console.WriteLine($"{ruiten}");
                    Console.WriteLine("De bank doet nu de trekking...");
                    Thread.Sleep(1000);
                    Console.WriteLine($"De bank heeft getrokken: {randomgetal} en {ruiten}");
                    break;
                case 9827:
                    Console.WriteLine($"{klaver}");
                    Console.WriteLine("De bank doet nu de trekking...");
                    Thread.Sleep(1000);
                    Console.WriteLine($"De bank heeft getrokken: {randomgetal} en {klaver}");
                    break;
            }
            Console.WriteLine("");
            int juistgetalhonderd = (randomgetal / 100) % 10;
            int juistkaarthonderd = (randomkaart / 100) % 10;
            int juistgetalduizend = (randomgetal / 1000) % 10;
            int juistkaartduizend = (randomkaart / 1000) % 10;
            int juistgetaltien = (randomgetal / 10) % 10;
            int juistkaarttien = (randomkaart / 100) % 10;
            int juistgetaleen = (randomgetal / 1) % 10;
            int juistkaarteen = (randomkaart / 100) % 10;

            if (juistgetalhonderd == juistkaarthonderd)
            {
                Console.WriteLine("Je hebt 3 cijfers juist geraden.");
                Console.WriteLine("Je wint ook de jackpot!");
                Console.WriteLine("Je wint 200 euro");
            }
            else if (juistgetalduizend == juistkaartduizend)
            {
                Console.WriteLine("Je hebt alle cijfers juist geraden.");
                Console.WriteLine("Je wint ook de jackpot!");
                Console.WriteLine("Je wint 1000 euro");
            }
            else if (juistgetaltien == juistkaarttien)
            {
                Console.WriteLine("Je hebt 2 cijfers juist geraden.");
                Console.WriteLine("Je wint ook de jackpot!");
                Console.WriteLine("Je wint 5 euro");
            }
            else if (juistgetaleen == juistkaarteen)
            {
                Console.WriteLine("Je hebt 1 cijfer juist geraden.");
                Console.WriteLine("Je wint ook de jackpot!");
                Console.WriteLine("Je wint 1 euro");
            }
            else
            {
                Console.WriteLine("Volgende keer beter");
            }

            Console.WriteLine("");
}
    }
}
