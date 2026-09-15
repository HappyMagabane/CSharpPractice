namespace DoWhileLoopAverageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Continuous Average Calculator: ");
            Console.WriteLine("Instructions: Enter positive numbers one by one.");
            Console.WriteLine("Enter any negative number to stop and see the average.\n");

            double totalSum = 0;
            int count = 0;
            double inputNumber;

            
            do
            {
                Console.Write("Enter a number: ");
                inputNumber = double.Parse(Console.ReadLine());

               
                if (inputNumber >= 0)
                {
                    totalSum += inputNumber; 
                    count++;                 
                }

            } while (inputNumber >= 0); 

           
            Console.WriteLine("\n-------------------------------------------------");
            if (count > 0)
            {
                double average = totalSum / count;
                Console.WriteLine($"Total Positive Numbers Entered : {count}");
                Console.WriteLine($"Sum of Positive Numbers        : {totalSum}");
                Console.WriteLine($"Calculated Average             : {average:F2}"); 
            }
            else
            {
                Console.WriteLine("No positive numbers were entered to calculate an average.");
            }
        }
    }
}
