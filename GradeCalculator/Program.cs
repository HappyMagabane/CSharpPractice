namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Exam Grade Calculator ---");
            Console.Write("Enter your exam score (0 - 100): ");

            if (double.TryParse(Console.ReadLine(), out double score))
            {
                
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("[!] Error: Score must be between 0 and 100.");
                    return;
                }

                char grade;

                
                if (score >= 90)
                {
                    grade = 'A';
                }
                else if (score >= 80) 
                {
                    grade = 'B';
                }
                else if (score >= 70) 
                {
                    grade = 'C';
                }
                else if (score >= 60) 
                {
                    grade = 'D';
                }
                else 
                {
                    grade = 'F';
                }

                
                Console.WriteLine("\n==============================");
                Console.WriteLine($" Your Score: {score}%");
                Console.WriteLine($" Final Grade: {grade}");
                Console.WriteLine("==============================");
            }
            else
            {
                Console.WriteLine("\n[!] Error: Please enter a valid numerical score.");
            }
        }
    }
}
