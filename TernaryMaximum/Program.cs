namespace TernaryMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double max = (num1 > num2) ? num1 : num2;
            Console.WriteLine($"The maximum of {num1} and {num2} is: {max}");
        }
    }
}
