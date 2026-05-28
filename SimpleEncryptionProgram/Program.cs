namespace SimpleEncryptionProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Simple Encryption Program ---");

            Console.WriteLine("Enter the message to encrypt:");
            string message = Console.ReadLine();

          
            Console.Write("Enter a shift key (a number, e.g., 3): ");
            if (!int.TryParse(Console.ReadLine(), out int shiftKey))
            {
                Console.WriteLine("[!] Invalid key. Please enter a whole number.");
                return;
            }

            
            string encryptedMessage = "";

        
            foreach (char letter in message)
            {
               
                if (char.IsLetter(letter))
                {
                    
                    char offset = char.IsUpper(letter) ? 'A' : 'a';

                    
                    int letterPosition = letter - offset;

             
                    int shiftedPosition = (letterPosition + shiftKey) % 26;

                    
                    if (shiftedPosition < 0) shiftedPosition += 26;

                    
                    char encryptedLetter = (char)(shiftedPosition + offset);
                    encryptedMessage += encryptedLetter;
                }
                else
                {
                    
                    encryptedMessage += letter;
                }
            }

       
            Console.WriteLine("\n==============================");
            Console.WriteLine("ENCRYPTED MESSAGE: ");
            Console.WriteLine("==============================");
            Console.WriteLine(encryptedMessage);
           
        }
    }
}
  
