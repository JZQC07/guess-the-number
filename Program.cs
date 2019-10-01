using System;

namespace guess_the_number
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Random randomerare = new Random();
                int nummer = randomerare.Next(1, 100);
                int antalgissningar = 10;
                int gissning = 101;
                Console.WriteLine("Välkommen! Ett tal mellan 1-100 har slumpats ut.");
                Console.WriteLine("Du har 10 chanser på dig att gissa rätt tal!");
                while (nummer != gissning && antalgissningar < 11)
                {
                    Console.WriteLine("Gissningar kvar: {0}", antalgissningar);
                    gissning = int.Parse(Console.ReadLine());
                    antalgissningar--;
                    if (gissning > nummer)
                    {
                        Console.WriteLine("Talet är mindre!");
                    }
                    else if (gissning < nummer)
                    {
                        Console.WriteLine("Talet är större!");
                    }
                }
                if (nummer == gissning)
                {
                    Console.WriteLine("Du lyckades gissa rätt med {0} försök kvar!", antalgissningar);
                    Console.WriteLine("Grattis!");
                }
                else if (antalgissningar == 0)
                {
                    Console.WriteLine("Du har gissat för många gånger...");
                    Console.WriteLine("Du förlorar.");
                }
                Console.WriteLine("Spela igen?? [J] / [N]");
                string playAgain = Console.ReadLine();
                if(playAgain == "N")
                {   
                    Console.WriteLine("Tryck valfri tangent för att avsluta programmet..");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

        }
    }
}
