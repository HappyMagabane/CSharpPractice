namespace SimpleBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int bankOption = 0;
            double amount = 0;
            double accountBalance= 1000.00; 


            Console.WriteLine("Welcome to Simple Banking");


            while (bankOption != 4)
            {

                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                bankOption = int.Parse(Console.ReadLine());

                if (bankOption == 1)
                {
                    Console.WriteLine($"\nYour current balance is: R{accountBalance:F2}");
                }
                else if (bankOption == 2)
                {
                    Console.Write("\nEnter deposit amount: R");
                    amount = double.Parse(Console.ReadLine());

                    if (amount > 0)
                    {
                        accountBalance += amount;
                        Console.WriteLine($"Successfully deposited R{amount:F2}. New balance: R{accountBalance:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Deposit must be greater than R 0.");
                    }
                }
                else if (bankOption == 3)
                {
                    Console.Write("\nEnter withdrawal amount: R");
                    amount = double.Parse(Console.ReadLine());

                    if (amount > 0 && amount <= accountBalance)
                    {
                        
                        accountBalance -= amount;
                        Console.WriteLine($"Successfully withdrew R{amount:F2}. New balance: R{accountBalance:F2}");
                    }
                    else if (amount > accountBalance)
                    {
                        Console.WriteLine("Transaction Denied: Insufficient funds.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Withdrawal must be greater than 0.");
                    }
                }
                else if (bankOption == 4)
                {
                    Console.WriteLine("\nThank you for using our banking system. Goodbye!");
                }
                else
                {
                    Console.WriteLine("\nInvalid option. Please choose a number between 1 and 4.");
                }
            }
        }
    }
}
