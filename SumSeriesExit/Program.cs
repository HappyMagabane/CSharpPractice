namespace SumSeriesExit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Series Exit: ");
            Console.WriteLine("Enter numbers one by one to add them to the total.");
            Console.WriteLine("Enter any negative number to exit and see the sum.\n");

            double sum = 0;

            while (true)
            {
                Console.Write("Enter a number: ");

                if (double.TryParse(Console.ReadLine(), out double inputNumber))
                {
                  
                    if (inputNumber < 0)
                    {
                        Console.WriteLine("Negative number detected. Exiting input loop...");
                        break;
                    }

                    sum += inputNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numerical value.\n");
                }
            }

            Console.WriteLine($"Total Sum: {sum}");
           
        }
    }
}
    
