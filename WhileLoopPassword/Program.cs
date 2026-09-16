namespace WhileLoopPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "SecretC@2026";
            string enteredPassword;

            Console.WriteLine("System Security Blockage:");

            
            do
            {
                Console.Write("Enter the password to unlock the system: ");
                enteredPassword = Console.ReadLine();

                
                if (enteredPassword != correctPassword)
                {
                    Console.WriteLine("Access Denied! Incorrect password. Try again.\n");
                }

            } while (enteredPassword != correctPassword); 

            
            Console.WriteLine("\n=================================");
            Console.WriteLine("Access Granted! Welcome back.");
        }
    }
}
