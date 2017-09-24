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
        private string addressLineOne;
        private string addressLineTwo;

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
        public string AddressLineOne
        {
            get { return this.addressLineOne; }
        }
        public string AddressLineTwo
        {
            get { return this.addressLineTwo; }
        }
        public Client()
        {
            this.clientFirstName = "John";
            this.clientLastName = "Smith";
            this.birthDate = "March 14, 1985";
            this.addressLineOne = "123 West Main Street";
            this.addressLineTwo = "Walla Walla, Washington 99362";
        }
        public void ClientInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + "\n" + clientFirstName + " " + clientLastName + "\n");
            Console.WriteLine("Birthdate: " +"\n" + birthDate + "\n");
            Console.WriteLine("Current Address: " + "\n" + addressLineOne);
            Console.WriteLine(addressLineTwo + "\n");
        }
        
    }
}
