namespace DoWhileLoopRollDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Dice Roll Simulator ===");
            Console.WriteLine("Rolling the die until we hit a 6...\n");

            Random randomDice = new Random();
            int rollCount = 0;
            int currentRoll;

     
            do
            {
                
                currentRoll = randomDice.Next(1, 7);

                rollCount++;

                
                Console.WriteLine($"Roll #{rollCount}: You rolled a [{currentRoll}]");

            } while (currentRoll != 6); 


            Console.WriteLine("\n=============================================");
            Console.WriteLine($"🎯 Success! It took a total of {rollCount} rolls to get a 6.");
           
        }
    }
}
