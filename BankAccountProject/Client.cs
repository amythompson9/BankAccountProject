using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Client
    {
        //Client Class
        //3 properties
        //1 constructor
        //1 method
        //Client information should be filled in here

        private string clientFirstName;
        private string clientLastName;
        private string birthDate;
        private string socialSecurityNumber;
        private string clientAddress;

        public string ClientFirstName
        {
            get { return this.clientFirstName; }
        }
        public string ClientLastName
        {
            get { return this.clientLastName; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
        }
        public string SocialSecurityNumber
        {
            get { return this.socialSecurityNumber; }
        }
        public string ClientAddress
        {
            get { return this.clientAddress; }
        }
        public Client(string clientFirstName, string clientLastName, string birthDate, string socialSecurityNumber, string clientAddress)
        {
            this.clientFirstName = clientFirstName;
            this.clientLastName = clientLastName;
            this.birthDate = birthDate;
            this.socialSecurityNumber = socialSecurityNumber;
            this.clientAddress = clientAddress;
        }
        public void ClientInformation()
        {
            Console.WriteLine("Name: " + "\n" + clientFirstName + " " + clientLastName + "\n");
            Console.WriteLine("Birthdate: " +"\n" + birthDate + "\n");
            Console.WriteLine("Social Security Number: " + "\n" + socialSecurityNumber + "\n");
            Console.WriteLine("Current Address: " + "\n" +clientAddress + "\n");
        }
    }
}
