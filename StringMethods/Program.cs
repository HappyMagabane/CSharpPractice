using System.ComponentModel.DataAnnotations;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sampleString = "Hello, Beautiful world. I am ";
            string inputString = string.Empty;

            int sampleLength = sampleString.Length;
            int imputLength = inputString.Length;
            bool isEmpty = string.IsNullOrEmpty(inputString);




            Console.Write($"String: \"{sampleString}\"");
            Console.Write($" Number of characters: {sampleLength}");
            Console.WriteLine($" Is string empty? {isEmpty}");


            Console.Write($"String: \"{inputString}\"");
            Console.Write($" Number of characters: {imputLength}");
            Console.WriteLine($" Is string empty? {isEmpty}");


            Console.Write("Please enter a letter to search for in the string: ");
            char searchChar = Console.ReadKey().KeyChar;

            int firstOccurrence = sampleString.IndexOf(searchChar);
            if (firstOccurrence != -1)
            {
                Console.WriteLine($"\nThe first occurrence of '{searchChar}' is at index: {firstOccurrence}");
            }
            else
            {
                Console.WriteLine($"\nThe character '{searchChar}' was not found in the string.");
            }

            string upperCaseString = sampleString.ToUpper();
            Console.WriteLine($"Uppercase version of the string: {upperCaseString}");
            string lowerCaseString = sampleString.ToLower();
            Console.WriteLine($"Lowercase version of the string: {lowerCaseString}");

            string replacedString = sampleString.Replace("world", "universe");
            Console.WriteLine("Replaced string: " + replacedString);

            Console.Write("Enter your name: ");
            Console.WriteLine("Concanated text: " + replacedString + Console.ReadLine());

            string extractSubstring = sampleString.Substring(0, 5);
            Console.WriteLine($"Extracted substring: {extractSubstring}");

            bool startsWithHello = sampleString.StartsWith("Hello");
            Console.WriteLine($"Does the string start with 'Hello'? {startsWithHello}");
            bool endsWithPeriod = sampleString.EndsWith(".");
            Console.WriteLine($"Does the string end with '.'? {endsWithPeriod}");

            Console.Write("Enter a string to search for: ");
            string searchString = Console.ReadLine();
            bool containsSearchString = sampleString.Contains(searchString);
            Console.WriteLine($"Does the string contain '{searchString}'? {containsSearchString}");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            bool isNameInString = sampleString.Contains(name);
            Console.WriteLine($"Is your name in the string? {isNameInString}");

            int startIndex = sampleString.IndexOf("Beautiful");
            if (startIndex != -1)
            {
                string extractedSubstring = sampleString.Substring(startIndex, "Beautiful".Length);
                Console.WriteLine($"Copied word: {extractedSubstring}");
            }
            else
            {
                Console.WriteLine("The word 'Beautiful' was not found in the string.");
            }

            string[] wordsArray = sampleString.Split(' ');
            foreach (string word in wordsArray)
            {

                Console.WriteLine($"{word} ({word.Length})");
            }

                string joinedString= String.Join(" ", wordsArray);
                Console.WriteLine($"Joined string: {joinedString}");

            

















        }
    }
}

