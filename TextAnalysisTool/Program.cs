namespace TextAnalysisTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Text Analysis Tool ---");
            Console.WriteLine("Please enter the text you want to analyze:");

            
            string userText = Console.ReadLine();

           
            if (string.IsNullOrWhiteSpace(userText))
            {
                Console.WriteLine("\n[!] You didn't enter any text to analyze.");
                return;
            }

            
            int charWithSpaces = userText.Length;

           
            int charWithoutSpaces = userText.Replace(" ", "").Length;

           
            string[] words = userText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int wordCount = words.Length;

            
            Console.WriteLine("\n==============================");
            Console.WriteLine("        STATISTICS        ");
            Console.WriteLine("==============================");
            Console.WriteLine($" Word Count:                {wordCount}");
            Console.WriteLine($" Characters (with spaces):   {charWithSpaces}");
            Console.WriteLine($" Characters (no spaces):     {charWithoutSpaces}");
            Console.WriteLine("==============================");
        }
    }
}
  
