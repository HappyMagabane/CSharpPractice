namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Movie Ticket Price Calculator ---");

            
            double standardPrice = 120.00;
            double discountedPrice = 60.00; 

            Console.Write("Please enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                
                if (age < 0 || age > 125)
                {
                    Console.WriteLine("[!] Error: Please enter a valid age.");
                    return;
                }

                double finalPrice;

              
                if (age < 12 || age > 65)
                {
                    finalPrice = discountedPrice;
                    Console.WriteLine("\n[+] Congratulations! You qualify for our Special Age Discount.");
                }
                else
                {
                    finalPrice = standardPrice;
                    Console.WriteLine("\nStandard rate applies.");
                }

               
                Console.WriteLine("=====================================");
                Console.WriteLine($" Your Ticket Price: R{finalPrice:F2}");
                Console.WriteLine("=====================================");
            }
            else
            {
                Console.WriteLine("\n[!] Error: Please enter a valid numerical value for age.");
            }
        }
    }
}
 
