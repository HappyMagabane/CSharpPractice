namespace RandomNumberBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();

            Console.WriteLine("Generating random numbers until a value greater than 50 appears:\n");

           
            while (true)
            {
                int currentNumber = randomGenerator.Next(1, 101);

                Console.WriteLine($"Generated Number: {currentNumber}");

                if (currentNumber > 50)
                {
                    Console.WriteLine($"\nA number {currentNumber} is greater than 50. Loop exited.");
                    break; // The random number generated is greater than 50, therefore breaks out of the infinite while loop
                }
            }

            Console.WriteLine("Program execution complete.");
        }
    }
}
