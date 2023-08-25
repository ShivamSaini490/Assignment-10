using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
}

sealed class SavingsAccount : BankAccount
{
    public decimal CalculateInterest(decimal interestRate)
    {
        decimal interest = Balance * interestRate;
        return interest;
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savingsAccount = new SavingsAccount
        {
            AccountNumber = "123456789",
            Balance = 1000
        };

        decimal interestRate = 0.05m;
        decimal interest = savingsAccount.CalculateInterest(interestRate);

        Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
        Console.WriteLine($"Balance: ${savingsAccount.Balance}");
        Console.WriteLine($"Interest Rate: {interestRate:P}");
        Console.WriteLine($"Interest Earned: ${interest}");

        Console.ReadLine();
    }
}
