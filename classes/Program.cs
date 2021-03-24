using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var invalidAcoount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            var account = new BankAccount("gurpartap", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            try
            {
                account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine( "Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
                Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
