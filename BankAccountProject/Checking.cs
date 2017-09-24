using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Checking: AccountBase
    {
        public Checking()
        {
            this.accountNumber = 123456789;
            this.accountBalance = 1000.25d;
            this.accountType = "Checking";
        }
        public override void DisplayAccountNumber()
        {
            Console.WriteLine("Account Number: {0}" + "\n", + accountNumber);
        }
        public override void DisplayAccountBalance()
        {
            Console.WriteLine("Account Balance: {0}" + "\n", accountBalance);
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking" + "\n");
        }
        public void Deposit(double depositAmount)
        {
            AccountBalance += depositAmount;
        }
        public void Withdraw(double withdrawAmount)
        {
            AccountBalance -= withdrawAmount;
        }
        public void Overdraw(double withdrawAmount)
        {
            Console.WriteLine();
            Console.WriteLine("This amount will overdraw your checking account.");
            AccountBalance += withdrawAmount;
            Console.WriteLine();
            Console.WriteLine("Your current balance is ${0}.", AccountBalance);
            Console.WriteLine();
            Console.WriteLine("How much would you like to withdraw from your checking account today?");
            Console.WriteLine();
            withdrawAmount = double.Parse(Console.ReadLine());
            Withdraw(withdrawAmount);
        }
    }
}
