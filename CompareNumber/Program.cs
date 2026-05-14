namespace CompareNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
                Console.WriteLine("The first number is smaller than the second number.");
            else if (num1 > num2)
                Console.WriteLine("The first number is greater than the second number.");
            else
                Console.WriteLine("Both numbers are equal.");





        }
    }
}
