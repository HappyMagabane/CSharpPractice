using System.Transactions;

namespace LogicPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the learner's marks (0-100");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the learner's attendance percentage (0-100)");
            int attendance = Convert.ToInt32(Console.ReadLine());

            int passingMarks = 60;
            int passingAttendance = 80;

            if (marks >= passingMarks && attendance >= passingAttendance)
            {
                Console.WriteLine("Congratulations! You have passed the course.");
            }
            else
            {
                Console.WriteLine("Unfortunately, you have not passed the course. Please try again.");
            }
        }
    }
}
