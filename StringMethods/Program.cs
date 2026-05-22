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
            char[] nameChars = Console.ReadLine().ToCharArray();
            Console.WriteLine($" {string.Join(", ", nameChars)} ");













        }
        }
    }

