namespace FibonacciSeriesGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms to generate: ");
            if (int.TryParse(Console.ReadLine(), out int terms) && terms > 0)
            {
                long first = 0;
                long second = 1;

                Console.WriteLine("\nFibonacci Series:");

                for (int i = 0; i < terms; i++)
                {
                   
                    Console.Write(first + (i < terms - 1 ? ", " : "\n"));

                  
                    long next = first + second;
                    first = second;
                    second = next;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }
    }
}
