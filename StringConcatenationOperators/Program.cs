namespace StringConcatenationOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first sentence:");
            string sentence1 = Console.ReadLine();

            Console.WriteLine("Please enter the second sentence:");
            string sentence2 = Console.ReadLine();

            string fullSentence = sentence1 + " " + sentence2;
            Console.WriteLine("The full sentence is: " + fullSentence);

        }
    }
}
