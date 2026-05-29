namespace IfPositiveNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if (userInput > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}


