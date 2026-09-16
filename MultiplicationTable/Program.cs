namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
