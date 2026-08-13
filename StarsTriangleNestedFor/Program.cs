namespace StarsTriangleNestedFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Nested Loop Star Triangle ===\n");

            
            int totalRows = 5;

            
            for (int row = 1; row <= totalRows; row++)
            {
               
                for (int col = 1; col <= row; col++)
                {
                    
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
