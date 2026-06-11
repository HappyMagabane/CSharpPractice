namespace MultiplicationNestedForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================================================");
            Console.WriteLine("                       MULTIPLICATION TABLE (1 - 10)                     ");
            Console.WriteLine("=========================================================================\n");

            
            for (int row = 1; row <= 10; row++)
            {
               
                for (int col = 1; col <= 10; col++)
                {
                   
                    int product = row * col;

                   
                    Console.Write($"{product}\t");
                }

                Console.WriteLine();
            }

       
        }
    }
}
