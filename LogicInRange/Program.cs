using System.ComponentModel.Design;

namespace LogicInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 100:");
            int inputNumber= int .Parse(Console.ReadLine());

            int lowerLimit = 1;
            int upperLimit = 100;

            if (inputNumber >= lowerLimit && inputNumber <= upperLimit)
            {
                Console.WriteLine("Number is between the range!");
            }
            else
            {
                Console.WriteLine("Number is out of the range!");
            }



              

        }
    }
}
