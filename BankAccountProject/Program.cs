using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        //1. View Client Information
        //2. View Account Balance
        //3. Deposit Funds
        //4. Withdraw Funds
        //5. Exit

            static void MainMenu()
        {
            
        }
        static void Main(string[] args)
        {
            //Program Class
            // Must instantiate one client object
            //Must instantiate one checking account object
            //Must instantiate one savings account object
            //All menu options listed above must have functionality behind them

            //Program should run until user selects 'Exit'

            //Other Tasks

            //After each transaction, the current balance should be displayed on the screen.
            //Your program should include:
            //1 abstract method(at least)
            //1 virtual method(at least)
            //1 override method(at least)

            Client client1 = new Client();
            Checking checkingAccount = new Checking();
            Savings savingsAccount = new Savings();
            Console.WriteLine("Welcome to The Bank. You got money in it.");
            Console.WriteLine();
            string mainMenu = "Main Menu \n\n1. View Client Information \n2. View Account Balance \n3. Withdraw Funds \n4. Deposit Funds \n5. Exit\n";
            Console.WriteLine(mainMenu);
            while (true)
            {
                
                int menuChoice = int.Parse(Console.ReadLine());
                if (menuChoice == 5)
                {
                    Console.WriteLine("Thank you for using The Bank.");
                    Console.WriteLine();
                    break;
                }
                else if (menuChoice == 1)
                {
                    client1.ClientInformation();
                    Console.WriteLine();
                    Console.WriteLine(mainMenu);
                    Console.WriteLine();
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("1. Checking Account Balance \n2. Savings Account Balance");
                    int checkAccountBalance = int.Parse(Console.ReadLine());
                    if (checkAccountBalance == 1)
                    {
                        checkingAccount.DisplayAccountType();
                        checkingAccount.DisplayAccountNumber();
                        checkingAccount.DisplayAccountBalance();
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
                    }
                    else if (checkAccountBalance == 2)
                    {
                        savingsAccount.DisplayAccountType();
                        savingsAccount.DisplayAccountNumber();
                        savingsAccount.DisplayAccountBalance();
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine("1. Withdraw from Checking Account \n2. Withdraw from Savings Account");
                    int withdrawFromAccount = int.Parse(Console.ReadLine());
                    if (withdrawFromAccount == 1)
                    {
                        Console.WriteLine("How much would you like to withdraw from your checking account today?");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        checkingAccount.Withdraw(withdrawAmount);
                        Console.WriteLine("Your new current balance is ${0}", checkingAccount.AccountBalance);
                    }
                    else if (withdrawFromAccount == 2)
                    {
                        Console.WriteLine("How much would you like to withdraw from your savings account today?");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        savingsAccount.Withdraw(withdrawAmount);
                        Console.WriteLine("Your new current balance is ${0}", savingsAccount.AccountBalance);
                    }
                }
                else if (menuChoice == 4)
                {
                    Console.WriteLine("1. Deposit into Checking Account \n2. Deposit into Savings Account");
                    int depositIntoAccount = int.Parse(Console.ReadLine());
                    if (depositIntoAccount == 1)
                    {
                        Console.WriteLine("How much would you like to deposit into your checking account today?");
                        double depositAmount = double.Parse(Console.ReadLine());
                        checkingAccount.Deposit(depositAmount);
                        Console.WriteLine("Your new current balance is ${0}", checkingAccount.AccountBalance);
                    }
                    else if (depositIntoAccount == 2)
                    {
                        Console.WriteLine("How much would you like to deposit into your savings account today?");
                        double depositAmount = double.Parse(Console.ReadLine());
                        savingsAccount.Deposit(depositAmount);
                        Console.WriteLine("Your new current balance is ${0}", savingsAccount.AccountBalance);
                    }
                }
                else
                {
                    Console.WriteLine("Please choose from the options listed below.");
                    MainMenu();
                }
            }
        }
    }
}
