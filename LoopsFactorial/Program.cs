namespace LoopsFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Factorial Calculator ===");

            
            Console.WriteLine("Enter a positive whole number: ");
            int number = int.Parse(Console.ReadLine());

            
            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }

         
            long factorialResult = 1;

          
            for (int i = 1; i <= number; i++)
            {
                
                factorialResult *= i;
            }

            
            Console.WriteLine($"\nThe factorial of {number} ({number}!) is: {factorialResult}");
        }
    }
    
}
