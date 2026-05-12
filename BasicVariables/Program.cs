using static System.Net.Mime.MediaTypeNames;

namespace BasicVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myAge = 25; // myAge initializes with your age.
            double myHeight = 1.75; // myHeight initializes with your height in meters.
            bool IsPermentResident = true; // IsPermentResident initializes with true if you are a permanent resident, otherwise false.
            string myNickname = "Lethabo"; // myNickname initializes with your nickname.
            double myEstimatedNetWorth = 1000000.00; // myEtimatedNetWorth initializes with your estimated net worth.
            string myLinkedIn = "https://www.linkedin.com/in/happymagabane/"; // myLinkedIn initializes with the URL of your LinkedIn profile.

            Console.Write("Please enter your nickname: ");
            myNickname = Console.ReadLine();
            Console.Write("Please enter your age: ");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your height in meters: ");
            myHeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are you a permanent resident? (true/false): ");
            IsPermentResident = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Please enter your estimated net worth: ");
            myEstimatedNetWorth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the URL of your LinkedIn profile: ");
            myLinkedIn = Console.ReadLine();


            Console.WriteLine("My nickname is " + myNickname);
            Console.WriteLine($"I am {myAge} years old.");
            Console.WriteLine("My height is {0} " ,myHeight + " meters.");
            Console.WriteLine($"Permanent resident? {IsPermentResident}");
            Console.WriteLine($"My estimated net worth is R{myEstimatedNetWorth}");
            Console.WriteLine($"You can find me on LinkedIn: {myLinkedIn}");    

            
        }
    }
}
