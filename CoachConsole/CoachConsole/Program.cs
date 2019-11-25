using System;

namespace CoachConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach myCoach = new Coach();

            for (int i = 0; i < 5; i++)
            {
                Person p = new Person();
                Console.WriteLine("Enter the name.");
                p.SetName(Console.ReadLine());

                if (myCoach.AddPerson(p) == true)
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("Failure.");
                }
            }

            Person p1 = new Person();

            Console.ReadLine();
        }
    }
}