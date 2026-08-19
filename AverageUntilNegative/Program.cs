namespace AverageUntilNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double sum = 0;
            int count = 0;

            
            do
            {
                Console.Write("Enter a number (negative number to stop): ");
                number = Convert.ToDouble(Console.ReadLine());

               
                if (number >= 0)
                {
                    sum += number;
                    count++;
                }

            } while (number >= 0);

          
            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"\nTotal valid numbers entered: {count}");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average:F2}");
            }
            else
            {
                Console.WriteLine("\nNo positive numbers were entered.");
            }
    }
    }
}
