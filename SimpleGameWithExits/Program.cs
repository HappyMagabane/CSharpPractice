namespace SimpleGameWithExits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
               
                Console.WriteLine("=== Number Guessing Game Menu ===");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. Exit");
                Console.Write("\nSelect an option (1 or 2): ");

                string choice = Console.ReadLine()?.Trim();
                Console.WriteLine();

              
                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid option! Please enter 1 to play or 2 to exit.\n");
                    continue; 
                }

                if (choice == "2")
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    break; 
                }

                int targetNumber = random.Next(1, 11);

                Console.WriteLine("I'm thinking of a number between 1 and 10.");
                Console.Write("Enter your guess: ");

                if (int.TryParse(Console.ReadLine(), out int userGuess))
                {
                    if (userGuess == targetNumber)
                    {
                        Console.WriteLine($"🎉 Correct! You guessed the secret number: {targetNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"❌ Incorrect! The secret number was {targetNumber}. Better luck next time!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid guess! You must enter a valid whole number.");
                }

            }
        }
    }
    
}
