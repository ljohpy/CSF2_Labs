using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login
    {
        //Fields
        private string _userName;
        private string _password;   

        //Properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }

        }
        //Constructors
        public Login (string userName, string password)
        {
            UserName = userName;    
            Password = password;
        }
        public Login()
        {

        }
        //Methods
        public override string ToString()
        {
            return string.Format ($"User Name: {UserName} \nUser Password: {Password}");
        }

    }
}
