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
        }
        public Savings(int accountNumber, double accountBalance, double withdrawMoney, double depositMoney, double minimumBalance)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawMoney = withdrawMoney;
            this.depositMoney = depositMoney;
            this.minimumBalance = minimumBalance;
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Savings Account Number: " + accountNumber + "\n");
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Savings Account Balance: " + accountBalance + "\n");
        }
        public override void DisplayWithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw from your Savings Account?");
            double amountFromSavings = double.Parse(Console.ReadLine());
            double newSavingsBalance = (accountBalance - amountFromSavings);
        }
        public override void DisplayDepositMoney()
        {

        }
    }
}
