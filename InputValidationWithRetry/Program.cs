namespace InputValidationWithRetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Positive Integer Validation ===");

            int validNumber;

       
        InputPrompt:

            Console.Write("Please enter a positive integer (> 0): ");

  
            if (int.TryParse(Console.ReadLine(), out validNumber) && validNumber > 0)
            {
             
                Console.WriteLine("\n=================================");
                Console.WriteLine($"Success! You entered: {validNumber}");
                Console.WriteLine("=================================");
            }
            else
            {
               
                Console.WriteLine("Error: Value must be a positive whole number greater than 0. Try again.\n");

            
                goto InputPrompt;
            }
        }
    }
}

