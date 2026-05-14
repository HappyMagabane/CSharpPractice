namespace AssignmentCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int totalIterations = 9;

            while (counter < totalIterations)
            {
                counter += 1;
                Console.WriteLine($"Counter: {counter}");
            }
        }
    }
}
