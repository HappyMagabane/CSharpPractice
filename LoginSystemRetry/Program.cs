namespace LoginSystemRetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctPassword = "AdminPassword2026";
            const int maxAttempts = 3;
            int attemptsUsed = 0;

            Console.WriteLine("=== Secure Login System ===");

        LoginPrompt:

            attemptsUsed++;
            Console.Write($"Attempt {attemptsUsed} of {maxAttempts} - Enter password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == correctPassword)
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine("Access Granted! Login successful.");
                Console.WriteLine("=================================");
                return; 
            }

            Console.WriteLine("Incorrect password.");

            if (attemptsUsed < maxAttempts)
            {
                int attemptsRemaining = maxAttempts - attemptsUsed;
                Console.WriteLine($"You have {attemptsRemaining} attempt(s) remaining. Try again.\n");

                goto LoginPrompt;
            }
            else
            {
              
                Console.WriteLine("Account locked: Too many failed attempts.");
          
            }
        }
    }
    
}
