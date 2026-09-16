namespace GoToMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Settings");
            Console.WriteLine("3. Help");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option (1-4): ");

            string selection = Console.ReadLine();
            Console.WriteLine();

            bool shouldExit = false;

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Starting the program...");
                    break; // Switch statement is exited

                case "2":
                    Console.WriteLine("Opening Settings...");
                    break; // Switch statement is exited

                case "3":
                
                    Console.WriteLine($"Opening Help...");
                    break; // Exits switch statement

                case "4":
                    Console.WriteLine("Exiting program. ");
                    shouldExit = true;
                    break; // Switch statement is exited

                default:
                    Console.WriteLine("Invalid option. Please enter a digit from 1 to 4.");
                    break; // Switch statement is exited
            }


            if (shouldExit)
            {
                return; // Terminates while (true) loop

            }
                Console.WriteLine("\n---------------------------------------------\n");
       
        }


    }
}

