using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.BankApp
{
    public class Account
    {
        public string OwnerName { get; }
    public string AccountNumber { get; }
    public string PIN { get; }
    public static decimal Balance { get; private set; }

    public Account(string ownerName, string accountNumber, decimal initialBalance)
    {
        OwnerName = ownerName;
        AccountNumber = accountNumber;
        PIN = accountNumber; // For simplicity, using the account number as PIN
        Balance = initialBalance;
    }

    public static void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }

    public static void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }
    }
}
