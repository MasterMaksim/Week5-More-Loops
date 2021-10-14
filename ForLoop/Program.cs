using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "I will not skateboard in the halls.".ToUpper();
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
