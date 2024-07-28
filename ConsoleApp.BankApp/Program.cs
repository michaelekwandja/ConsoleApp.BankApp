using ConsoleApp.BankApp;
using System;
using System.Collections.Generic;

class Program
{
    static List<Account> accountList = new List<Account>();

    static void Main()
    {
        // Create some sample accounts (replace with real data)
        accountList.Add(new Account("John Doe", "1234", 1000.00M));
        accountList.Add(new Account("Jane Smith", "5678", 2000.00M));

        Console.WriteLine("Welcome to the ATM!");
        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter your PIN: ");
        string pin = Console.ReadLine();

        Account userAccount = AuthenticateUser(accountNumber, pin);

        if (userAccount != null)
        {
            ShowMenu(userAccount);
        }
        else
        {
            Console.WriteLine("Invalid account number or PIN. Exiting.");
        }
    }

    static Account AuthenticateUser(string accountNumber, string pin)
    {
        foreach (var account in accountList)
        {
            if (account.AccountNumber == accountNumber && account.PIN == pin)
            {
                return account;
            }
        }
        return null;
    }

    static void ShowMenu(Account userAccount)
    {
        Console.WriteLine($"Welcome, {userAccount.OwnerName}!");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Deposit");
        Console.WriteLine("4. Exit");

        Console.Write("Select an option: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Your balance: ${Account.Balance}");
                break;
            case 2:
                Console.Write("Enter withdrawal amount: $");
                decimal withdrawal = decimal.Parse(Console.ReadLine());
                Account.Withdraw(withdrawal);
                Console.WriteLine($"Your balance: ${Account.Balance}");
                break;
            case 3:
                Console.Write("Enter deposit amount: $");
                decimal deposit = decimal.Parse(Console.ReadLine());
                Account.Deposit(deposit);
                Console.WriteLine($"Your balance: ${Account.Balance}");
                break;
            case 4:
                Console.WriteLine("Thank you for using the ATM!");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

