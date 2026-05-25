namespace AccessStringCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string userWord = Console.ReadLine();

            if (userWord.Length > 0)
            {

                char firstLetter = userWord[0];
                char lastLetter = userWord[userWord.Length - 1];
                Console.WriteLine($"First letter: {firstLetter}");
                Console.WriteLine($"Last letter: {lastLetter}");

            }
            else
            {
                Console.WriteLine("Invalid word entered");

            }
        }
    }
}
