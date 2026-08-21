namespace PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number <= 1)
                {
                    Console.WriteLine($"{number} is not a prime number.");
                    return;
                }

                bool isPrime = true;

                for (int i = 2; i < number; i++)
                {

                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }
}
