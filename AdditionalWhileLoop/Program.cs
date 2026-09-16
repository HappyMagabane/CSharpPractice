namespace AdditionalWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Digits Calculator: ");

            Console.Write("Enter a whole number: ");
            int number = int.Parse(Console.ReadLine());

            
            int temporaryNumber = Math.Abs(number);
            int runningSum = 0;

           
            while (temporaryNumber > 0)
            {
               
                int lastDigit = temporaryNumber % 10;

                
                runningSum += lastDigit;

               
                temporaryNumber = temporaryNumber / 10;
            }

          
            Console.WriteLine($"\nThe sum of the digits in {number} is: {runningSum}");
        }
    }
}
