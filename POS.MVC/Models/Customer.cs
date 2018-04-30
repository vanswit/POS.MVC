using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class Customer : POSEntity
    {
        public int Id { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Address Address { get; set; }
        public string EmailAddress { get; set; }

        public Customer()
        {
            
        }

        public Customer(string lastName, string firstName, Address address, string emailAddress)
        {
            LastName = lastName;
            FirstName = firstName;
            Address = address;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public override bool Validate()
        {
            //Validate object
            return IsValid;
        }
    }
}
