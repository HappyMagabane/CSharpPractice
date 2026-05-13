namespace ConstantVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159; 
            const double SPEED_OF_LIGHT = 299792458;

            double distance, radius;

            Console.WriteLine("Enter the radius of a circle (test value: 6371000): ");
            radius= double.Parse(Console.ReadLine());
            
            double area = PI * radius * radius;

            Console.WriteLine("The area of the circle with radius " + radius + " is: " + area);
            Console.ReadLine();

            Console.WriteLine("Enter the distance in meters (test value: 384 400 000): ");
            distance = double.Parse(Console.ReadLine());

            double time = distance / SPEED_OF_LIGHT;
            Console.WriteLine("The time it takes for light to travel " + distance + " meters is: " + time + " seconds.");
            Console.ReadLine();




        }
    }
}
