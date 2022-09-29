// See https://aka.ms/new-console-template for more information
using System;

namespace NumberAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string usersName = Console.ReadLine();

            bool repeatProgram;

            do
            {
                Console.WriteLine($"{usersName}, please enter a number between 1 and 100, inclusive.");
                int usersNumber = Convert.ToInt32(Console.ReadLine());

                if (usersNumber >= 1 && usersNumber <= 100)
                {
                    bool evenNumber;
                    if (usersNumber % 2 == 0)
                    {
                        evenNumber = true;
                    }
                    else
                    {
                        evenNumber = false;
                    }

                    if (evenNumber == false && usersNumber < 60)
                    {
                        Console.WriteLine($"{usersNumber} is odd and less than 60.");
                    }

                    if (evenNumber == true && (usersNumber >= 2 && usersNumber <= 24))
                    {
                        Console.WriteLine("Even and less than 25.");
                    }

                    if (evenNumber == true && (usersNumber >= 26 && usersNumber <= 60))
                    {
                        Console.WriteLine("Even and between 26 and 60 inclusive.");
                    }

                    if (evenNumber == true && usersNumber > 60)
                    {
                        Console.WriteLine($"{usersNumber} is even and greater than 60.");
                    }

                    if (evenNumber == false && usersNumber > 60)
                    {
                        Console.WriteLine($"{usersNumber} is odd and greater than 60.");
                    }

                    Console.WriteLine("Would you like to play again? (yes/no)");
                    string playAgain = Console.ReadLine();

                    if (playAgain.ToLower() == "yes")
                    {
                        repeatProgram = true;
                    }
                    else
                    {
                        repeatProgram = false;
                        Console.WriteLine($"Goodbye, {usersName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"That is not a valid number, {usersName}. Goodbye!");
                    repeatProgram = false;
                }
            }
            while (repeatProgram == true);
        }
    }
}
