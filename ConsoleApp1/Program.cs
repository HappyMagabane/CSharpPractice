namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("1. Greet User");
                Console.WriteLine("2. Display Current Date & Time");
                Console.WriteLine("3. Print a Random Number");
                Console.WriteLine("4. Exit");
                Console.Write("\nSelect an option (1-4): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

               
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hello! Welcome to the application.");
                        break; // Exits the switch statement

                    case "2":
                        Console.WriteLine($"Current Date/Time: {DateTime.Now}");
                        break; // Exits the switch statement

                    case "3":
                        Random random = new Random();
                        Console.WriteLine($"Random number: {random.Next(1, 101)}");
                        break; // Exits the switch statement

                    case "4":
                        Console.WriteLine("Exiting program. Goodbye!");
                        keepRunning = false; 
                        break; // Exits the switch statement

                    default:
                        Console.WriteLine("Invalid selection. Please choose an option from 1 to 4.");
                        break; // Exits the switch statement
                }

               
                if (!keepRunning)
                {
                    break; 
                }

                Console.WriteLine("\n------------------------------------\n");
            }

            Console.WriteLine("\nProgram execution finished.");
        }
    }
    
}
