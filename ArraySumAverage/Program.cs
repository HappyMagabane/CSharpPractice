using System;

namespace ArraySumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Array Sum and Average Calculator ===");

            double[] numbers = new double[5];

            Console.WriteLine("Please enter 5 numbers:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number for index [{i}]: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = sum / numbers.Length;

            Console.WriteLine($"Total Sum : {sum}");
            Console.WriteLine($"Average   : {average:F2}");

        }
    }
}
