using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer
    {
        //FIELDS
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        //PROPERTIES
        public string CustomerID
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public ContactInfo ContactInformation
        {
            get { return _contactInformation; }
            set { _contactInformation = value; }
        }

        //CONSTRUCTORS
        public Customer() { }

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format("-=-= Customer =-=-\n" +
                "Name: {0}, {1}\t\tID: {2}\n{3}",
                LastName, FirstName, CustomerID, ContactInformation);
        }
    }
}
