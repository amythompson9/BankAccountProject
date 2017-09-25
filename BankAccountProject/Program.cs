using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void MainMenu()
        {
            
        }
        static void Main(string[] args)
        {
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
                    Console.WriteLine();
                    Console.WriteLine("Thank you for choosing The Bank.");
                    Console.WriteLine();
                    break;
                }
                else if (menuChoice == 1)
                {
                    client1.ClientInformation();
                    Console.WriteLine();
                    Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                    Console.WriteLine();
                    int infoMenu = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (infoMenu == 1)
                    {
                        Console.WriteLine(mainMenu);
                    }
                    else if (infoMenu == 5)
                    {
                        Console.WriteLine("Thank you for choosing The Bank.");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid number.");
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
                    }
                    
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Checking Account Balance \n2. Savings Account Balance");
                    Console.WriteLine();
                    int checkAccountBalance = int.Parse(Console.ReadLine());
                    if (checkAccountBalance == 1)
                    {
                        Console.WriteLine();
                        checkingAccount.DisplayAccountType();
                        checkingAccount.DisplayAccountNumber();
                        checkingAccount.DisplayAccountBalance();
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else if (checkAccountBalance == 2)
                    {
                        Console.WriteLine();
                        savingsAccount.DisplayAccountType();
                        savingsAccount.DisplayAccountNumber();
                        savingsAccount.DisplayAccountBalance();
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid number.");
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Withdraw from Checking Account \n2. Withdraw from Savings Account");
                    Console.WriteLine();
                    int withdrawFromAccount = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (withdrawFromAccount == 1)
                    {
                        Console.WriteLine("How much would you like to withdraw from your checking account today?");
                        Console.WriteLine();
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        checkingAccount.Withdraw(withdrawAmount);
                        while (checkingAccount.AccountBalance < 0)
                        {
                            checkingAccount.Overdraw(withdrawAmount);
                        }
                        if (checkingAccount.AccountBalance > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Your new current balance is ${0}", checkingAccount.AccountBalance);
                        }
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else if (withdrawFromAccount == 2)
                    {
                        Console.WriteLine("How much would you like to withdraw from your savings account today?");
                        Console.WriteLine();
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        savingsAccount.Withdraw(withdrawAmount);
                        while (savingsAccount.AccountBalance < savingsAccount.MinimumBalance)
                        {
                            savingsAccount.Minimum(withdrawAmount);
                        }
                        if (savingsAccount.AccountBalance > savingsAccount.MinimumBalance)
                        {
                            Console.WriteLine("Your new current balance is ${0}", savingsAccount.AccountBalance);
                        }
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid number.");
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
                    }
                }
                else if (menuChoice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Deposit into Checking Account \n2. Deposit into Savings Account");
                    Console.WriteLine();
                    int depositIntoAccount = int.Parse(Console.ReadLine());
                    if (depositIntoAccount == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("How much would you like to deposit into your checking account today?");
                        Console.WriteLine();
                        double depositAmount = double.Parse(Console.ReadLine());
                        checkingAccount.Deposit(depositAmount);
                        Console.WriteLine();
                        Console.WriteLine("Your new current balance is ${0}", checkingAccount.AccountBalance);
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else if (depositIntoAccount == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("How much would you like to deposit into your savings account today?");
                        Console.WriteLine();
                        double depositAmount = double.Parse(Console.ReadLine());
                        savingsAccount.Deposit(depositAmount);
                        Console.WriteLine();
                        Console.WriteLine("Your new current balance is ${0}", savingsAccount.AccountBalance);
                        Console.WriteLine();
                        Console.WriteLine("To return to the Main Menu, press '1'. \nTo Exit, press '5'.");
                        Console.WriteLine();
                        int infoMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (infoMenu == 1)
                        {
                            Console.WriteLine(mainMenu);
                        }
                        else if (infoMenu == 5)
                        {
                            Console.WriteLine("Thank you for choosing The Bank.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                            Console.WriteLine(mainMenu);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid number.");
                        Console.WriteLine();
                        Console.WriteLine(mainMenu);
                        Console.WriteLine();
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
