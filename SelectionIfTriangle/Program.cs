namespace SelectionIfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Triangle Validity Checker ---");

           
            Console.Write("Enter the length of Side A: ");
            if (!double.TryParse(Console.ReadLine(), out double sideA)) return;

            Console.Write("Enter the length of Side B: ");
            if (!double.TryParse(Console.ReadLine(), out double sideB)) return;

            Console.Write("Enter the length of Side C: ");
            if (!double.TryParse(Console.ReadLine(), out double sideC)) return;

          
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("\n[!] Error: Side lengths must be greater than zero.");
                return;
            }

          
            if ((sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA))
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine(" SUCCESS: These sides form a VALID triangle! ");
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("\n=================================");
                Console.WriteLine(" FAILURE: These sides DO NOT form a valid triangle. ");
                Console.WriteLine("=================================");
            }
        }
    }
}
    
