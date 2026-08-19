namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game: ");

            const int targetNumber = 21;
            int userGuess;

            do
            {
                Console.Write("Guess a number between 1 and 100: ");

                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    if (userGuess > targetNumber)
                    {
                        Console.WriteLine("Too high! Try again.\n");
                    }
                    else if (userGuess < targetNumber)
                    {
                        Console.WriteLine("Too low! Try again.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid whole number.\n");
                    userGuess = -1; 
                }

            } while (userGuess != targetNumber); 

            Console.WriteLine("Congratulations! You guessed the correct number: {targetNumber}");
        }
    }
}
