using ClassLibrary;

namespace Labs2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactInfo ci1 = new ContactInfo();
            ci1.StreetAddress = "1007 Mountain Drive";
            ci1.City = "Gotham";
            ci1.State = "New York";
            ci1.Zip = "01234";
            ci1.Phone = "123-456-7890";
            ci1.Email = "the@batman.com";

            Customer c1 = new Customer();
            c1.CustomerID = "rb123";
            c1.FirstName = "John";
            c1.LastName = "Blake";
            c1.ContactInformation = ci1;

            Console.WriteLine(c1);

            ContactInfo ci2 = new ContactInfo("000 Insane Avenue",
                "Gotham", "New York", "00000", "098-765-4321",
                "jo@ke.r");

            Customer c2 = new Customer("jk126", "Melvin", "White", ci2);

            Console.WriteLine(c2);


            CreditCardAccount cc1 = new CreditCardAccount();
            cc1.AccountNumber = 323235;
            cc1.CustomerInfo = c1;
            cc1.Balance = 2309235.32m;
            cc1.IsPastDue = false;
            cc1.AnnualInterestRate = .25m;

            Console.WriteLine(cc1);

            CreditCardAccount cc2 = new CreditCardAccount(4664363, c2, -2353234.40m, true, 0);

            Console.WriteLine(cc2);


        }
    }
}