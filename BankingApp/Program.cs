namespace BankingApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Karol's bank!");

        //Banking account1 = new Banking { AccountId = 1, Description = "Checking" };
        //Banking account2 = new Banking { AccountId = 2, Description = "Checking" };

        Savings account1 = new Savings("Savings");
        Savings account2 = new Savings("Savings");



        while (true)
        {
            Console.WriteLine("Choose an operation: deposit, withdraw, balance or transfer.");
            var operation = Console.ReadLine();

            if (operation == "deposit")
            {
                Console.WriteLine("How much?");
                var amount = Convert.ToInt32(Console.ReadLine());

                account1.Deposit(amount);
            }

            if (operation == "withdraw")
            {
                Console.WriteLine("How much?");
                var amount = Convert.ToInt32(Console.ReadLine());

                account1.Withdraw(amount);
            }

            if (operation == "balance")
            {

                account1.DisplayBalance();
            }

            if (operation == "transfer")
            {
                Console.WriteLine("How much?");
                var amount = Convert.ToInt32(Console.ReadLine());
               

                account1.Transfer(amount, account2);
            }

        }
    }
}
