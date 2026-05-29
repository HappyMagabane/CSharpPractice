namespace IfCredentials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "Admin";
            string correctPassword = "MyPassword123";

            Console.WriteLine("--- Login System ---");

            Console.Write("Enter Username: ");
            string inputUsername = Console.ReadLine();

           
            Console.Write("Enter Password: ");
            string inputPassword = Console.ReadLine();

        
            if (string.Equals(inputUsername, correctUsername, StringComparison.OrdinalIgnoreCase) && inputPassword == correctPassword)
            {
             
                Console.WriteLine("\n==============================");
                Console.WriteLine("  Welcome! Login successful.  ");
                Console.WriteLine("==============================");
            }
            else
            {
     
                Console.WriteLine("\n==============================");
                Console.WriteLine("  ERROR: Invalid Credentials! ");
                
            }
        }
    }
}
