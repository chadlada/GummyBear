

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
            Console.WriteLine("I will use my black magic to determine a number between 1 and 1024..Think of it in your head. Don't tell me. then hit enter");
            Console.WriteLine();

            Console.ReadLine();
        }


        static void GuessNumber(int low, int high)
        {
            var mid = (low + high) / 2;
            Console.WriteLine($"Is your number {mid}? Type 'y' for yes, 'l' for lower, or 'h' for higher.");
            var result = Console.ReadLine();

            if (result == "y")
            {
                Console.WriteLine("You got it!");
            }
            else if (result == "l")
            {
                var newMax = mid;
                Console.WriteLine("mid " + mid);
                GuessNumber(low, newMax);
                // -if lower, then set guessed number as new maximum, keep minimum, and determine new middle for next guess. 
                // (max512 min0)
            }
            else if (result == "h")
            {
                var newMin = mid;
                GuessNumber(newMin, high);
                // -if higher, then set guessed number as new minimum, keep maximum, and determine new middle for next guess. 
                // (Max1024 min512)
            }
            else
            {
                Console.WriteLine("Please type 'y', 'l', or 'h'");
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

