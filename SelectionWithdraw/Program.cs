namespace SelectionWithdraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Welcome to the ATM Program ---");

            
            Console.Write("Please enter your current account balance: R");
            if (!double.TryParse(Console.ReadLine(), out double balance))
            {
                Console.WriteLine("[!] Error: Invalid numeric value entered for balance.");
                return;
            }

            
            if (balance > 0)
            {
               
                Console.Write($"\nYour balance is R{balance:F2}. Enter amount to withdraw: R");
                if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                {
                   
                    if (withdrawAmount <= 0)
                    {
                        Console.WriteLine("[!] Error: Withdrawal amount must be greater than zero.");
                    }
                    else if (withdrawAmount <= balance)
                    {
                       
                        balance -= withdrawAmount; 
                        Console.WriteLine("\n=================================");
                        Console.WriteLine("   Preparing cash... Please wait. ");
                        Console.WriteLine($"   Remaining Balance: R{balance:F2}");
                        
                    }
                    else
                    {
                       
                        Console.WriteLine("\n[!] Error: Insufficient funds for this withdrawal.");
                    }
                }
                else
                {
                    Console.WriteLine("[!] Error: Invalid numeric value entered for withdrawal.");
                }
            }
            else
            {
              
                Console.WriteLine("\n=================================================");
                Console.WriteLine("  ERROR: Account balance must be greater than R0  ");
                Console.WriteLine("  to perform transactions. Access Denied.         ");
                Console.WriteLine("=================================================");
            }
        }
    }
}

