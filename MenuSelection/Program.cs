namespace MenuSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== WELCOME TO THE COFFEE HOUSE =====");
            Console.WriteLine("1. Burger & Chips");
            Console.WriteLine("2. Margherita Pizza");
            Console.WriteLine("3. Chicken Salad");
            Console.WriteLine("4. Cappuccino");
            Console.WriteLine("=======================================");
            Console.Write("Please enter the number of your choice (1-4): ");

           
            string input = Console.ReadLine();

            
            if (int.TryParse(input, out int choice))
            {
                string itemName = "";
                double itemPrice = 0.00;
                bool validSelection = true;

                
                switch (choice)
                {
                    case 1:
                        itemName = "Burger & Chips";
                        itemPrice = 85.00;
                        break;
                    case 2:
                        itemName = "Margherita Pizza";
                        itemPrice = 95.00;
                        break;
                    case 3:
                        itemName = "Chicken Salad";
                        itemPrice = 70.00;
                        break;
                    case 4:
                        itemName = "Cappuccino";
                        itemPrice = 35.00;
                        break;
                    default:
                        
                        validSelection = false;
                        break;
                }

               
                if (validSelection)
                {
                    Console.WriteLine("\n=======================================");
                    Console.WriteLine("             YOUR ORDER                ");
                    Console.WriteLine("=======================================");
                    Console.WriteLine($" Item Selected: {itemName}");
                    Console.WriteLine($" Total Price:   R{itemPrice:F2}");
                    Console.WriteLine("=======================================");
                }
                else
                {
                    Console.WriteLine("\n[!] Invalid menu option. Please select a number between 1 and 4.");
                }
            }
            else
            {
                Console.WriteLine("\n[!] Error: Please enter a valid numeric digit.");
            }
        }
    }
}
