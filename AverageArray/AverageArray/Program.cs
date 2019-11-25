using System;

namespace AverageArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int total = 0;

            Console.WriteLine("Please input your 10 numbers.");
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                int input = (Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                numbers[i] = input;
                total = total + input;
            }

            int mean = total / 10;

            Console.WriteLine("The average of your numbers is {0}", mean);
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
