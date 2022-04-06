using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary; 
namespace Labs1
{
    internal class DataTypePagesLab
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.FirstName = "Bobby";
            s1.LastName = "Foxy";
            s1.Id = "6969696969";
            s1.Gpa = 4.0m;
            Console.WriteLine("Student Name: {0}\t{1}\nStudent Id: {2}\n Student GPA: {3}", s1.FirstName, s1.LastName, s1.Id, s1.Gpa);

            Students s2 = new Students("Teddy", "Bruce", "456789", 4.0m);
            Console.WriteLine(s2);

            Vehicle v1 = new Vehicle();
            v1.Make = "Lexus";
            v1.Model = "Rx350";
            v1.Year = 2022;
            v1.Weight = 50000m;
            Console.WriteLine("Vehicle Make: {0}\t Vehicle Model: {1} \n Vehicle Year: {2}\n Total Weight: {3}  ", v1.Make, v1.Model, v1.Year, v1.Weight);
            Vehicle v2 = new Vehicle("Lexus", "Rx350", 2022, 50000m);
            Console.WriteLine(v2);

            Login l1 = new Login();
            l1.UserName = "ljohpy";
            l1.Password = "Bigdaddy69";
            Console.WriteLine("UserName:{0}\nPassword: {1} ", l1.UserName, l1.Password);
            Login l2 = new Login("ljohpy", "Bigdaddy69");
            Console.WriteLine(l2);

            ContactInfo c1 = new ContactInfo();
        


                c1.StreetAddress = "8888 st st";
                c1.City = "Wentzville";
            c1.State = "MO";
            c1.Zip = "63385";
            c1.Email ="berthg@gmail.com";
            c1.Phone ="(314) 754-8555";

            Console.WriteLine("Street Address:{0)\n City {1}\n State{2}\n Zip{3}\n Email {4} \n Phone{5}", c1.StreetAddress, c1.City, c1.State,c1.Zip,c1.Email, c1.Phone);
            ContactInfo c2 = new ContactInfo("45 Berth Ave", "Wentzville", "MO", "63385", "berthg@gmail.com", "(314)7545564");
            Console.WriteLine(c2);


        }//end main
    }//end class
}//end namespace
