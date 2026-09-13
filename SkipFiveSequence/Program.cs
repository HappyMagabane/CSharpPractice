namespace SkipFiveSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sequence 1 to 10 (Skipping 5) ===\n");

            for (int i = 1; i <= 10; i++)
            {
            
                if (i == 5) //Checking if the current number is 5
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }
    }
    
}
