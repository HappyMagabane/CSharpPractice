namespace IfLeapYearProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Leap Year Checker ---");
            Console.Write("Please enter a year (e.g., 2024): ");

            // 1. Get input from the user
            string input = Console.ReadLine();

            // 2. Safely convert the text input into an integer year
            if (int.TryParse(input, out int year))
            {
                // 3. Use the built-in DateTime.IsLeapYear method
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"\n[+] {year} IS a leap year!");
                }
                else
                {
                    Console.WriteLine($"\n[-] {year} is NOT a leap year.");
                }
            }
            else
            {
                // If the user types letters instead of a number
                Console.WriteLine("\n[!] Error: Please enter a valid numerical year.");
            }
        }
    }
}
