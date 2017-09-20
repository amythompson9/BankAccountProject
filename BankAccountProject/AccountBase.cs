using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class AccountBase
    {
        //An account number
        //Balance
        //An account type(savings or checking)
        //A way to view the current balance
        //User must be able to deposit money into either account
        //User must be able to withdraw money from either account
        //Make sure to include the following Classes

        protected int accountNumber;
        protected double accountBalance;
        protected double withdrawMoney;
        protected double depositMoney;

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

        public AccountBase()
        {

        }

        public AccountBase(int accountNumber, double accountBalance, double withdrawMoney, double depositMoney)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.withdrawMoney = withdrawMoney;
            this.depositMoney = depositMoney;
        }
        public virtual void DisplayAccountNumber()
        {

        }
        public virtual void DisplayAccountBalance()
        {

        }
        public virtual void DisplayWithdrawMoney()
        {

        }
        public virtual void DisplayDepositMoney()
        {

        }
    }
}
