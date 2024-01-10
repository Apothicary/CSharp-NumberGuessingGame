namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialise necessary variables
            Random random = new Random();
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            bool playAgain = true;
            string response;

            // Outer loop for restarting the game
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";

                // Generate a random number between min and max 
                number = random.Next(min, max + 1);

                // Inner loop for one round of the game
                while (guess != number)
                {
                    // Prompt the user to guess a number within the given range
                    Console.WriteLine("Guess a number between " + min + " - " + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    // Provide feedback to the user based on their guess
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low");
                    }

                    // Increment the number of guesses
                    guesses++;
                }

                // Display the correct number and the success message
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: " + guesses);

                // Ask the user if they want to play again
                Console.WriteLine("Would you like to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                // Determine whether to play again based on the user's response
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            // Display a thank you message when the user decides to exit
            Console.WriteLine("Thanks for playing!");

            // Wait for a key press before closing the console window
            Console.ReadKey();
        }
    }
}