namespace ArrayMinMaxFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Array Min & Max Finder ===");

          
            double[] numbers = new double[5];

          
            Console.WriteLine("Please enter 5 numbers:\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number for index [{i}]: ");
                numbers[i] = double.Parse(Console.ReadLine());
            }

            
            double min = numbers[0];
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                // Check for a new maximum value
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

               
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

     
            Console.WriteLine($"Minimum Value: {min}");
            Console.WriteLine($"Maximum Value: {max}");
        
        }
    }
}
