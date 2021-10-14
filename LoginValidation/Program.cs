using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i < 3){
                Console.WriteLine("Sisesta kasutajatunnus: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna: ");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    Console.WriteLine("Proovi uuesti!");
                    i++;
                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                }
            }
        }
    }
}
