using System;

namespace PoemWordCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            TheCounter dictionary = new TheCounter(100);
            string[] poem = Console.ReadLine().Split(" ");

            for (int i = 0 < PoemWordCounter.Length; i++)
            {
                dictionary.AddWordToList(poem[i]);
            }

            while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);
                }
            }
        }
    }
}
