namespace dataTypesCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = (int) Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            int num2 = (int) Decimal.Parse(Console.ReadLine());   

            int sum = num1 + num2;
            double quotient = num1 / num2;
            
            Console.WriteLine($"The sum of the two numbers is: {sum}");
            
            Console.WriteLine($"The quotient of the two numbers is: {quotient}");

            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} / {num2} = {quotient}");


        }
    }
}
