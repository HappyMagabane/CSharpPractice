namespace BooleanVote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age!");
            int age = Convert.ToInt32(Console.ReadLine());

            bool canVote = age >= 18;

            if (canVote)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
    }
}
