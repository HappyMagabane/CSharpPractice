namespace IfAdultProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int userInput= int.Parse(Console.ReadLine());

            if (userInput >= 18)
            {
                Console.WriteLine("You are an adult!");
            }
            else
            {
                Console.WriteLine("You are a minor.");


            }

        }
    }
}


