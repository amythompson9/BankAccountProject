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

            Client client1 = new Client("John", "Smith", "March 14, 1985", "123 45 6789", "123 West Main Street \nWalla Walla, Washington 99362");
            Console.WriteLine("Welcome to The Bank. You got money in it.");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information \n2. View Account Balance \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");
            int menuChoice = int.Parse(Console.ReadLine());
            if (menuChoice == 1)
            {
                client1.ClientInformation();

            }
            else if (menuChoice == 2)
            {
                Console.WriteLine("1. Checking Account Balance \n2. Savings Account Balance");
                int checkAccountBalance = int.Parse(Console.ReadLine());
                if (checkAccountBalance == 1)
                {

                }
                else if (checkAccountBalance == 2)
                {
                    
                }
            }
            else if (menuChoice == 3)
            {

            }
            else if (menuChoice == 4)
            {

            }
            else if (menuChoice == 5)
            {
                Console.WriteLine("Thank you for using The Bank.");
            }
            else
            {
                Console.WriteLine("Please choose from the options listed below.");
                MainMenu();
            }
        }
    }
}
