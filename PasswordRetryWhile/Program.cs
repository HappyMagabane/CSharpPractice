namespace PasswordRetryWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string setPassword = "SecretPassword123";

            string enteredPassword = string.Empty;

            Console.WriteLine("=== Password Authentication Gateway ===");

            while (enteredPassword != setPassword)
            {
                Console.Write("Enter the password: ");
                enteredPassword = Console.ReadLine();

                if (enteredPassword != setPassword)
                {
                    Console.WriteLine("Incorrect password. Please try again.\n");
                }
            }

            
            Console.WriteLine("Access Granted!");
        }
    }
    }
