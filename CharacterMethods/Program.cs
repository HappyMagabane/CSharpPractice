namespace CharacterMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a single character: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || userInput.Length != 1)
            {
                Console.WriteLine("Error: You must enter exactly ONE character.");
                return;
            }
            char ch = userInput[0];


            if (char.IsLetter(ch))
            {
                Console.WriteLine(" It is a Letter.");
            }

            if (char.IsDigit(ch))
            {
                Console.WriteLine(" It is a Digit.");
            }

            if (char.IsWhiteSpace(ch))
            {
                Console.WriteLine(" It is a White Space.");
            }

  
            if (char.IsUpper(ch))
            {
                Console.WriteLine(" It is Uppercase.");
            }

            
            if (char.IsLower(ch))
            {
                Console.WriteLine(" It is Lowercase.");
            }

           
            if (char.IsLetterOrDigit(ch))
            {
                Console.WriteLine("- It is an Alphanumeric character (Both letter and number classification).");
            }
        }
    }
}
           
        







