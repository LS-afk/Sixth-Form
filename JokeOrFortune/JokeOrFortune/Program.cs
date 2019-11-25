using System;

namespace JokeOrFortune
{
    class Program
    {
        static void Main(string[] args)
        {
            void joke()
            {
                Console.WriteLine("");
                Console.WriteLine(" Ed is funny.");
                Console.WriteLine("");
                Console.WriteLine(" ");
                Console.ReadLine();
            }

            void fortune()
            {
                Console.WriteLine("");
                Console.WriteLine(" You will be lucky on a day ending with y.");
                Console.WriteLine("");
                Console.WriteLine(" ");
                Console.ReadLine();
            }

            char key;
            Console.WriteLine(" Welcome, press 1 for a joke, 2 for a fortune or x to exit.");
            Console.WriteLine("");
            Console.WriteLine(" ");
            key = Convert.ToChar(Console.ReadLine());

            if (key == '1')
            {
                joke();
            }

            else if (key == '2')
            {
                fortune();
            }

            else if (key == 'x')
            {
                
            }
        }
    }
}
