using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp;
internal class Savings : Banking //Savings is inheriting from Banking
{
    public decimal IntRate { get; set; } = 0.12m; //the m specifies it's decimal, otherwise it would be double
    public void CalcAndPayInterest(int NbrOfMonths)
    {
        decimal interest = Balance * (IntRate / 12) * NbrOfMonths;
        Deposit(interest);
    }

    public Savings(string description) : base(description)
    {

    }

}
