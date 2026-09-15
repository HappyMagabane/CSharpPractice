namespace SumOfDigitsWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a multi-digit number (e.g., 123): ");

            if (int.TryParse(Console.ReadLine(), out int inputNumber))
            {
               
                int originalNumber = inputNumber;

                
                int currentNumber = Math.Abs(inputNumber);

                int sumOfDigits = 0;

              
                while (currentNumber > 0)
                {
                  
                    int lastDigit = currentNumber % 10;

                    
                    sumOfDigits += lastDigit;

                    
                    currentNumber = currentNumber / 10;
                }

                
                Console.WriteLine($"\nThe sum of the digits in {originalNumber} is: {sumOfDigits}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid whole integer.");
            }
        }
    }
}
