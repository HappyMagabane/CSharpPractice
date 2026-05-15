namespace NullCoalescingOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? startDate = null;
            DateTime defaultDate = new DateTime(2001, 12, 31);
            DateTime finalDate = startDate ?? defaultDate;
            if (startDate == null)
            {
                Console.WriteLine($"Original startDate: {(startDate.HasValue ? startDate.Value.ToShortDateString() : "null")}");
                Console.WriteLine($"Default Birthdate: {defaultDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"Original startDate: {startDate.Value.ToShortDateString()}");
            }

           
        
    }
    }
}
