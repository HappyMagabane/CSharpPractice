namespace FirstLettersDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Please enter your First and Middle names: ");
            string inputNames = Console.ReadLine();

            
            string cleanedInput = inputNames.Trim();

        
            string[] namesArray = cleanedInput.Split(' ');

            
            if (namesArray.Length >= 2)
            {
                
                string firstName = namesArray[0];
                string middleName = namesArray[1];

              
                char firstInitial = char.ToUpper(firstName[0]);
                char middleInitial = char.ToUpper(middleName[0]);

                
                Console.WriteLine($"\nOriginal Names: {firstName} {middleName}");
                Console.WriteLine($"Your Initials : {firstInitial}.{middleInitial}.");
            }
            else
            {
                Console.WriteLine("\nError: Please make sure you enter BOTH a first name and a middle name separated by a space.");
            }
        }
    }
}
      
