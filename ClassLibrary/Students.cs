using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Students
    {
        //Fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private decimal _gpa;

        //Properties

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
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public decimal Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        //Constructors
        public Students(string firstName, string lastName, string id, decimal gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        public Students()
        { }

        //METHODS
        public override string ToString()
        {
            return string.Format($"Student name: {FirstName}\t{LastName}\nStudent ID: {Id}\nStudent GPA: {Gpa}");
        }

    }
}
