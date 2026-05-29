namespace SwitchDayOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Day of the Week Finder ---");
            Console.WriteLine("Enter a number (1 for Monday, 2 for Tuesday, etc.): ");

           
            string input = Console.ReadLine();

          
            if (int.TryParse(input, out int dayNumber))
            {
                string dayName;

                
                switch (dayNumber)
                {
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    case 3:
                        dayName = "Wednesday";
                        break;
                    case 4:
                        dayName = "Thursday";
                        break;
                    case 5:
                        dayName = "Friday";
                        break;
                    case 6:
                        dayName = "Saturday";
                        break;
                    case 7:
                        dayName = "Sunday";
                        break;
                    default:
                        
                        dayName = "Invalid day! Please enter a number between 1 and 7.";
                        break;
                }

              
                Console.WriteLine($"\nResult: {dayName}");
            }
            else
            {
                
                Console.WriteLine("\n[!] Error: Please enter a valid numerical digit.");
            }
        }
    }
    
}
