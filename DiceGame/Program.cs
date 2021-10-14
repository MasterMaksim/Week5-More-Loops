using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int cpuRandom = rnd.Next(1, 7);
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Arvuti viskas: {cpuRandom}, ning Kasutaja siis: {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                    cpuRandom = rnd.Next(1, 7);
                    userRandom = rnd.Next(1, 7);
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud.");
                    cpuScore = cpuScore + 1;
                    cpuRandom = rnd.Next(1, 7);
                    userRandom = rnd.Next(1, 7);
                }
                else
                {
                    Console.WriteLine("Viik!");
                    cpuRandom = rnd.Next(1, 7);
                    userRandom = rnd.Next(1, 7);
                }
                Console.WriteLine($"User score: {userScore}");
                Console.WriteLine($"CPU score: {cpuScore}");

            }



            Console.WriteLine("Kena päeva!");
        }
    }
}
