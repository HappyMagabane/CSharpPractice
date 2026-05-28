namespace StringReversalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Word Order Reversal Program ---");
            Console.WriteLine("Please enter a sentence:");

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("\n[!] You didn't enter any text to reverse.");
                return;
            }

            
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

          
            Array.Reverse(words);

            string result = string.Join(" ", words);

            
            Console.WriteLine("\n==============================");
            Console.WriteLine("REVERSED SENTENCE: ");
         
            Console.WriteLine(result);
           
        }
    }
}


