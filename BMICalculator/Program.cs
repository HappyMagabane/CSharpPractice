namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index Calculator");

            
            Console.Write("Enter your weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in meters: ");
            double height = double.Parse(Console.ReadLine());

            
            double rawBMI = weight / (height * height);

           
            double roundedBMI = Math.Round(rawBMI);

            Console.WriteLine($"\nYour rounded BMI is: {roundedBMI}");

           
            if (roundedBMI < 18.5)
            {
                Console.WriteLine($"Your BMI is {roundedBMI} :You are Underweight");
            }
            else if (roundedBMI >= 18.5 && roundedBMI <= 24.9)
            {
                Console.WriteLine($"Your BMI is {roundedBMI}: You have a Healthy weight");
            }
            else if (roundedBMI >= 25.0 && roundedBMI <= 29.9)
            {
                Console.WriteLine($"Your BMI is {roundedBMI}: You are Overweight");
            }
            else
            {
                Console.WriteLine($"Your BMI is 30 and above: You are obese");
            }
        }
    }
}
