using System;

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.SetName(Console.ReadLine());
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p1.GetName() + " is aged " + p1.GetAge());
            
        }

    }

}
