namespace NumericWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting From 10 to 1:");

            
            int counter = 10;

            
            while (counter >= 1)
            {
                
                Console.WriteLine(counter);

                
                counter--;
            }

            Console.WriteLine("We have reached the end!");
        }
    }
}
