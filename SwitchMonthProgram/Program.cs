namespace SwitchMonthProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Month Finder Tool ---");
            Console.Write("Enter a number (1 for January, 2 for February, etc.): ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int monthNumber))
            {
                string monthName;

                switch (monthNumber)
                {
                    case 1:
                        monthName = "January";
                        break;
                    case 2:
                        monthName = "February";
                        break;
                    case 3:
                        monthName = "March";
                        break;
                    case 4:
                        monthName = "April";
                        break;
                    case 5:
                        monthName = "May";
                        break;
                    case 6:
                        monthName = "June";
                        break;
                    case 7:
                        monthName = "July";
                        break;
                    case 8:
                        monthName = "August";
                        break;
                    case 9:
                        monthName = "September";
                        break;
                    case 10:
                        monthName = "October";
                        break;
                    case 11:
                        monthName = "November";
                        break;
                    case 12:
                        monthName = "December";
                        break;
                    default:
                        
                        monthName = "Invalid month! Please enter a number between 1 and 12.";
                        break;
                }

                
                Console.WriteLine($"\nResult: {monthName}");
            }
            else
            {
             
                Console.WriteLine("\n[!] Error: Please enter a valid numerical digit.");
            }
        }
    }
}
    
