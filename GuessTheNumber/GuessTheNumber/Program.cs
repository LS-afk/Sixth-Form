using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber;
            randomNumber = rnd.Next(0, 101);
            int guess;
            int programClose;
            int counter;
            counter = 0;

            Console.WriteLine("Program: Guess The Number");
            Console.WriteLine("");
            Console.WriteLine("In this program, you will have to guess a random number between 1 and 100, and the program will tell");
            Console.WriteLine("you whether your guess is correct, too high or too low.");
            Console.WriteLine("");

            Console.WriteLine("Please input your guess.");
            Console.WriteLine("");
            guess = Convert.ToInt32(Console.ReadLine());
            counter = counter + 1;

            do
            {

                if (guess > randomNumber)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Your guess was too high, try again.");
                    Console.WriteLine("");
                    guess = Convert.ToInt32(Console.ReadLine());
                    counter = counter + 1;

                }

                if (guess < randomNumber)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Your guess was too low, try again.");
                    Console.WriteLine("");
                    guess = Convert.ToInt32(Console.ReadLine());
                    counter = counter + 1;

                }

                if (guess == randomNumber)
                {

                    Console.WriteLine("");
                    Console.WriteLine("You got it! You had "+counter+" guesses.");
                    Console.WriteLine("");
                    Console.WriteLine("Type any number and press enter to close the program.");
                    Console.WriteLine("");
                    programClose = Convert.ToInt32(Console.ReadLine());
                    counter = counter + 1;

                }      
                

            } while (guess != randomNumber);


        }
    }
}