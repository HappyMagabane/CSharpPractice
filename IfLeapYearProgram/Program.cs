namespace IfLeapYearProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Leap Year Checker ---");
            Console.Write("Please enter a year (e.g., 2001): ");

            
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out int year))
            {
               
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
               
                Console.WriteLine("\n[!] Error: Please enter a valid numerical year.");
            }
        }
    }
}
