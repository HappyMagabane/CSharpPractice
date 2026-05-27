namespace PasswordStrengthChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Enter your  password: ");
            string password = Console.ReadLine();

            bool hasLength = password.Length >= 8; 
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            string strength = "Weak"; 

          
            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                else if (char.IsLower(ch)) hasLower = true;
                else if (char.IsDigit(ch)) hasDigit = true;
                else if (!char.IsLetterOrDigit(ch) && !char.IsWhiteSpace(ch)) hasSpecial = true;
            }

       
            int additionalCriteriaMet = 0;
            if (hasUpper) additionalCriteriaMet++;
            if (hasLower) additionalCriteriaMet++;
            if (hasDigit) additionalCriteriaMet++;
            if (hasSpecial) additionalCriteriaMet++;

            if (hasLength && additionalCriteriaMet == 4)
            {
                strength = "Strong";
            }
            else if (hasLength && additionalCriteriaMet >= 1)
            {
                strength = "Moderate";
            }
            else
            {
                strength = "Weak";
            }

            Console.WriteLine($"• Minimum 8 Characters? : {(hasLength ? "PASSED" : "FAILED")}");
            Console.WriteLine($"• Contains Uppercase?   : {(hasUpper ? "PASSED" : "FAILED")}");
            Console.WriteLine($"• Contains Lowercase?   : {(hasLower ? "PASSED" : "FAILED")}");
            Console.WriteLine($"• Contains Digit/Number?: {(hasDigit ? "PASSED" : "FAILED")}");
            Console.WriteLine($"• Contains Special Char?: {(hasSpecial ? "PASSED" : "FAILED")}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Overall Password Rating: {strength.ToUpper()}");
        }
    }
}
   
