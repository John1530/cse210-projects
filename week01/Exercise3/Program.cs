using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        int userGuess = -1;
        int attempts = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        while (userGuess != randomNumber)
        {
            Console.Write("Please enter your guess (1-100): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userGuess))
            {
                attempts++;

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} in {attempts} attempts!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
            }
        }
        Console.WriteLine("Do you want to play again? (yes/no)");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "yes")        
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thank you for playing! Goodbye!");
        }
    }
}