namespace DiceRollSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int targetNumber = 6;
            int rolledNumber;
            int rollCount = 0;

            Console.WriteLine($"Rolling the dice until we get a {targetNumber}...\n");

            do
            {
                rolledNumber = random.Next(1, 7);
                rollCount++;

                Console.WriteLine($"Roll {rollCount}: You rolled a {rolledNumber}");
            } while (rolledNumber != targetNumber);

            Console.WriteLine($"\nSuccess! It took {rollCount} rolls to get {targetNumber} .");
        }
    }
}
 
