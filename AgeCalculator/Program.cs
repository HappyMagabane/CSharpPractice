namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your year of birth");
            int yearOfBirth = int.Parse(Console.ReadLine());

             int userAge= 2026 - yearOfBirth;
            Console.WriteLine("Your age is " + userAge);

        }
    }
}
