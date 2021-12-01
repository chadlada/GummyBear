# NumberGuesser

NumberGuess PEDAC

P
What is the number (between 1 and 1024) you are thinking in your head?
Can only receive higher or lower prompts from user to gauge number in users head.

- Once the program starts, you should display a greeting to the user describing the challenge.
- Ask the user to think of a number between 1 and 1024.
- Do NOT prompt the user for their number. Your program will guess the number IN THEIR MIND
- Prompt the user with your guess and allow them to tell you if their number is higher, lower, or correct.
- Keep refining your guess until you have the correct answer.
- Use methods to organize your code. Here are some suggestions for methods you might use:
  - ShowGreeting
  - ComputeNewLowIfTooLow
  - ComputeNewHighIfTooHigh
  - BragWhenCorrect
- Use at least one or two methods

E
Greetings! I will guess your number etc…Hit enter once you’ve determined your number.
Computer guess: 3
User: Lower
Computer Guess: 2
User: Lower
Computer Guess: Must be 1! Is this correct?
User: Yes

D
Loops, Methods, if/else, strings, integers

A

1. Greet user > Prompt to hit enter once they’ve got a number in their head.
2. Computer will guess number to begin (middle value between 1-1024)
3. Print first guess - Guess will be mid == (1024+1) / 2 = 512
4. Prompt user to input whether number is higher ‘h’, lower ‘l’, or yes ‘y’ (correct)
   -if higher, then set guessed number as new minimum, keep maximum, and determine new middle for next guess.
   -if lower, then set guessed number as new maximum, keep minimum, and determine new middle for next guess.
   -if correct, then done. Display some confirmation.

C
