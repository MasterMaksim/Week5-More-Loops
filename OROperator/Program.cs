using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kasutajatunnus: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna: ");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Proovi uuesti!");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
