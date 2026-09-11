namespace PositiveSumContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Instructions: Enter a number, 0 to exit.");
            

            double sum = 0;

            while (true)
            {
                Console.Write("Enter a number: ");

                if (double.TryParse(Console.ReadLine(), out double number))
                {
                 
                    if (number == 0)
                    {
                        Console.WriteLine("Exit signal received (0). Calculating total...");
                        break;
                    }

              
                    if (number < 0)
                    {
                        Console.WriteLine("-> Negative number skipped.");
                        continue; 
                    }

                
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                }
            }

          
            Console.WriteLine($"Sum of positive numbers: {sum}");
           
      
        }
    }
}
