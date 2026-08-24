namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Random Password Generator ===");

            string validCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+[]{}|;:,.<>?";

            Console.Write("Enter the desired password length (e.g., 12): ");

            if (int.TryParse(Console.ReadLine(), out int passwordLength) && passwordLength > 0)
            {
                Random random = new Random();
                string generatedPassword = "";

                for (int i = 0; i < passwordLength; i++)
                {
                    int randomIndex = random.Next(0, validCharacters.Length);

                    generatedPassword += validCharacters[randomIndex];
                };
                Console.WriteLine($"Generated Password: {generatedPassword}");
                Console.WriteLine($"Password Length   : {generatedPassword.Length} characters");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive whole number.");
            }
        }
    }
}
