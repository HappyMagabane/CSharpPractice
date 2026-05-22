namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Temperature Converter ===");

         
            Console.WriteLine("Choose your starting unit:");
            Console.WriteLine("1. Celsius (C)");
            Console.WriteLine("2. Fahrenheit (F)");
            Console.Write("Enter choice (1 or 2): ");
            string choice = Console.ReadLine();

          
            Console.Write("Enter the temperature value: ");
            double inputTemperature = double.Parse(Console.ReadLine());

           
            if (choice == "1")
            {
                
                double fahrenheit = (inputTemperature * 9.0 / 5.0) + 32;
                Console.WriteLine($"\nResult: {inputTemperature}°C is equal to {fahrenheit:F2}°F");
            }
            else if (choice == "2")
            {
                
                double celsius = (inputTemperature - 32) * 5.0 / 9.0;
                Console.WriteLine($"\nResult: {inputTemperature}°F is equal to {celsius:F2}°C");
            }
            else
            {
                Console.WriteLine("\nInvalid option selected. Please restart the program and enter 1 or 2.");
            }
        }
    }
};
        
    

