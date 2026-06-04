namespace ContinueStatementSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequence from 1 to 10 (Skipping 5):");

            
            for (int i = 1; i <= 10; i++)
            {
                
                if (i == 5)
                {
                    
                    continue;
                }

               
                Console.WriteLine(i);
            }

        }
    }
}
