

using System;

namespace NumberGuesser
{
    class Program
    {

        static void Main(string[] args)
        {
            var min = 1;
            var max = 1024;

            ShowGreeting();
            GuessNumber(min, max);
        }


        static void ShowGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to The Number Guesser    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("I will use my black magic to determine a number between 1 and 1024..Think of it in your head. Don't tell me.\n Hit ENTER when ready");
            Console.WriteLine();
            Console.ReadLine();
        }

        static void GuessNumber(int low, int high)
        {
            var mid = (low + high) / 2;
            Console.WriteLine($"is {mid} your number? \nType 'Y' for Yes, 'H' for higher, or 'L' for Lower");
            var result = Console.ReadLine().ToUpper();

            if (result == "Y")
            {
                Console.WriteLine("I got it! I got it! I read your mind!\n\n");
            }
            else if (result == "H")
            {
                var newMin = mid;
                GuessNumber(newMin, high);
            }
            else if (result == "L")
            {
                var newMax = mid;
                GuessNumber(low, newMax);
            }

            else
            {
                Console.WriteLine("Unexpected response..Cannot compute..");
            }

        }
        // Ask the user to think of a number between 1 and 1024.

        // Do NOT prompt the user for their number. Your program will guess the number IN THEIR MIND
        // Prompt the user with your guess and allow them to tell you if their number is higher, lower, or correct.
        // Keep refining your guess until you have the correct answer.
        // Use methods to organize your code. Here are some suggestions for methods you might use:
        // ShowGreeting
        // ComputeNewLowIfTooLow
        // ComputeNewHighIfTooHigh
        // BragWhenCorrect
        // Use at least one or two methods    }

    }
}

