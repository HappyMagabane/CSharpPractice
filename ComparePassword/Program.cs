namespace ComparePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PASSWORD = "myPass@2023";
            Console.WriteLine("Please enter your password!");
            string myPassword = Console.ReadLine();

            if (myPassword != PASSWORD)
            {
                Console.WriteLine("Password does not match");

            }
        }
    }
}
