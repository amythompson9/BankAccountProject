using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking: AccountBase
    {
        //Checking Account Class(derived)
        //1 constructor
        public int AccountNumber
        {
            get { return this.accountNumber; }
        }
        public double AccountBalance
        {
            get { return this.accountBalance; }
        }
        public double WithdrawMoney
        {
            get { return this.withdrawMoney; }
        }
        public double DepositMoney
        {
            get { return this.depositMoney; }
        }

        public Checking()
        {

        }

        public Checking(int accountNumber, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawMoney = withdrawMoney;
            this.depositMoney = depositMoney;
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Checking Account Number: " + accountNumber + "\n");
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Checking Account Balance: " + accountBalance + "\n");
        }
        public override void DisplayWithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw from your checking account today?");
            double amountFromChecking = double.Parse(Console.ReadLine());
            double newCheckingBalance = (accountBalance - amountFromChecking);
            Console.WriteLine("Your new checking account balance is $" + newCheckingBalance + "\n");
        }
        public override void DisplayDepositMoney()
        {
            Console.WriteLine("How much would you like to deposit into your checking account today?");
            double amountToChecking = double.Parse(Console.ReadLine());
            double newCheckingBalance = (accountBalance + amountToChecking);
            Console.WriteLine("Your new checking account balance is $" + newCheckingBalance + "\n");
        }
    }
}
