using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Random object to generate random numbers
        Random randomGenerator = new Random();
        // Generate a random number between 1 and 100 (inclusive)
        int magicNumber = randomGenerator.Next(1, 101);
        // Initialize the guess to -1, an initial value that is not a valid guess
        int guess = -1;
        // Start a loop that continues until the user guesses the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            // Read the user's input and convert it to an integer
            guess = int.Parse(Console.ReadLine());
            // Compare the user's guess with the magic number
            if (magicNumber > guess)
            {
                // If the magic number is greater, inform the user to guess higher
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                // If the magic number is smaller, inform the user to guess lower
                Console.WriteLine("Lower");
            }
            else
            {
                // If the guess matches the magic number, inform the user that they guessed it
                Console.WriteLine("You guessed it!");
            }

        }   // End of the while loop                 
    }
}