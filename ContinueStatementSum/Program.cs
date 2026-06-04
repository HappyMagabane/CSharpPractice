namespace ContinueStatementSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positive Numbers Sum Calculator:");
            Console.WriteLine("Instructions: Enter numbers one by one.");
            Console.WriteLine("Enter '0' when you are finished to see the total.\n");

            double sum = 0;
            double inputNumber = -1; 

           
            while (inputNumber != 0)
            {
                Console.Write("Please enter a number: ");
                inputNumber = double.Parse(Console.ReadLine());

                
                if (inputNumber == 0)
                {
                    break; 
                }

                
                if (inputNumber < 0)
                {
                    Console.WriteLine("-> Negative number detected! Skipping...");
                    continue; 
                }

                
                sum += inputNumber;
            }

            
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"The total sum of positive numbers is: {sum}");
            Console.WriteLine("=====================================");
        }
    }
}
