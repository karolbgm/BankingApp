using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp;
internal class Banking
{
    private static int nextId { get; set; } = 1; //The Banking class is taking care of assigning an AccountId 
    public int AccountId { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;

    public bool Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount can't be negative");
            return false;

        }
        Balance += amount;
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Amount can't be negative");
            return false;

        }
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return false;
        }

        Balance -= amount;
        return true;
    }

    public void DisplayBalance()
    {
        Console.WriteLine(Balance);
    }

    public bool Transfer(decimal amount, Banking account)
    {
        var success = this.Withdraw(amount);
        if (success == true)
        {
            account.Deposit(amount);
        }
        return true;
    }

    public Banking(string description)
    {
        AccountId = nextId++; //AccountId = AccountId + nextId
        Description = description; //We only need to pass description when creating an instance
        Balance = 0;
    }
}

//Remember: Properties follow PascalCase and parameters follow camelCase