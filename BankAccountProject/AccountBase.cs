using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    abstract class AccountBase
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
        protected string accountType;
        
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value;  }
        }
        

        public AccountBase()
        {

        }

        public AccountBase(int accountNumber, double accountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }
        public virtual void DisplayAccountNumber()
        {

        }
        public virtual void DisplayAccountBalance()
        {

        }
        public virtual void DisplayAccountType()
        {

        }
    }
}
