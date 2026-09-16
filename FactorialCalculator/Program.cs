namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter a whole number: ");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
              
                if (number < 0)
                {
                    Console.WriteLine("Error: You entered negative number(s).");
                    return;
                }

           
                long factorialResult = 1;

               
                for (int i = 1; i <= number; i++)
                {
                    factorialResult *= i; 
                }

                Console.WriteLine($"\nOutput: {factorialResult}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a whole number.");
            }
        }
    }
}
