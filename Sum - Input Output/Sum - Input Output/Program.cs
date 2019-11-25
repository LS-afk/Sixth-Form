using System;

namespace Sum___Input_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining each integer used in the program.
            int first;
            int second;
            int third;
            int answer;

            // The program tells the user what it is. The empty WriteLine serves as a spacing.
            Console.WriteLine("This is a program that will give the sum of three numbers.");
            Console.WriteLine("");

            // The program asks the user to input their first number and read the input as an integer value, subsequently defining it as 'first' for when it is added up at the end.
            Console.WriteLine("Input your first number.");
            Console.WriteLine("");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // The program asks the user to input their second number and read the input as an integer value again, this time the input being assigned as 'second'.
            Console.WriteLine("Input your second number.");
            Console.WriteLine("");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // The program asks the user to input their third number and read the input as an integer value, this time the input being assigned as 'third'.
            Console.WriteLine("Input your third number.");
            Console.WriteLine("");
            third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            // The program now defines 'answer' as the sum of the three now defined integers inputted previously by the user.
            answer = (first + second + third);
            Console.WriteLine("The sum of your three numbers is {0}", answer);
            Console.WriteLine("");

            // This ReadLine just stops the program from closing instantly after giving the answer.
            Console.ReadLine();
        }
    }
}