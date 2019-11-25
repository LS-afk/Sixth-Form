using System;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";

            int userAge = 0;

            int currentYear = 0;


            Console.WriteLine("Hello World!");
                    Console.WriteLine("");

            Console.WriteLine("What is your name?");
                    Console.WriteLine("");
            userName = Console.ReadLine();
                    Console.WriteLine("");
            Console.WriteLine("Hello {0}, nice to meet you.", userName);
                    Console.WriteLine("");

            Console.WriteLine("How old are you?");
                    Console.WriteLine("");
            userAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
            Console.WriteLine("Ok, so you are {0}.", userAge);
                    Console.WriteLine("");
            userName = Console.ReadLine();
        }
    }
}