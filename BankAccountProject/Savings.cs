using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Savings: AccountBase
    {
        //Note: Savings Account must include a minimum balance.
        //User cannot withdraw money if balance will drop below minimum.
        //1 property
        //1 constructor

        private double minimumBalance;
        public double MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }
        public Savings()
        {
            AccountNumber = 987654321;
            AccountBalance = 314.15d;
            AccountType = "Savings";
            this.minimumBalance = 100.00d;
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Savings Account Number: {0}" + "\n", accountNumber);
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Savings Account Balance: {0}" + "\n", accountBalance);
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings");
        }
        public void Deposit(double depositAmount)
        {
            AccountBalance += depositAmount;
        }
        public void Withdraw(double withdrawAmount)
        {
            AccountBalance -= withdrawAmount;
        }
        public void Minimum(double withdrawAmount)
        {
            Console.WriteLine("You must maintain a minimum balance of $100.00 in your Savings Account.");
            AccountBalance += withdrawAmount;
            Console.WriteLine();
            Console.WriteLine("Your current balance is ${0}.", AccountBalance);
            Console.WriteLine();
            Console.WriteLine("How much would you like to withdraw from your savings account today?");
            Console.WriteLine();
            withdrawAmount = double.Parse(Console.ReadLine());
            Withdraw(withdrawAmount);
            Console.WriteLine();
        }
    }
}
