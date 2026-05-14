using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;


            Console.WriteLine($"{num1} + {num2} = {addition}");
            Console.WriteLine($"{num1} - {num2} = {subtraction}");
            Console.WriteLine($"{num1} * {num2} = {multiplication}");
            Console.WriteLine($"{num1} / {num2} = {division}");
           




        }
    }
}
