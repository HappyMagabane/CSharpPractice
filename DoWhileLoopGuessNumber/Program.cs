namespace DoWhileLoopGuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game: ");

            
            Random randomGenerator = new Random();
            int secretNumber = randomGenerator.Next(1, 101); 

            int userGuess;

            Console.WriteLine("I have picked a secret number between 1 and 100.");
            Console.WriteLine("Can you guess what it is?\n");

            do
            {
                Console.Write("Enter your guess: ");

                
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                   
                    if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try a lower number.\n");
                    }
                    else if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try a higher number.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid whole number.\n");
                }

            } while (userGuess != secretNumber); 

           
            Console.WriteLine("\n=============================================");
            Console.WriteLine($"🎉 Congratulations! You guessed it! The number was {secretNumber}.");
            Console.WriteLine("=============================================");
        }
    }
}
