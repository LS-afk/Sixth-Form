using System;

namespace Multiplication_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber1;
            randomNumber1 = rnd.Next(0, 11);
            int randomNumber2;
            randomNumber2 = rnd.Next(0, 11);
            int answer = randomNumber1 * randomNumber2;
            int score = 0;
            int qNumber;

            Console.WriteLine("This program will contain a 10 question multiplication quiz. Type your answer underneath");
            Console.WriteLine("each question, and your score out of 10 will be shown at the end.");
            Console.WriteLine("");

            for (qNumber = 1; qNumber < 11; qNumber++)            
            {
                Console.WriteLine("Question {0}.", qNumber);
                Console.WriteLine("");
                randomNumber1 = rnd.Next(0, 11);
                randomNumber2 = rnd.Next(0, 11);
                Console.WriteLine("What is {0}x{1}?", randomNumber1, randomNumber2);
                Console.WriteLine("");

                if (Convert.ToInt32(Console.ReadLine()) == answer)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Your answer is correct!");
                    Console.WriteLine("");
                    score = score + 1;

                }
                else
                {

                    Console.WriteLine("");
                    Console.WriteLine("Your answer is incorrect.");
                    Console.WriteLine("");
                
                }

            }

            Console.WriteLine("Your final score is {0}.", score);
            Console.WriteLine("");

            Convert.ToInt32(Console.ReadLine());
        }
    }
}
