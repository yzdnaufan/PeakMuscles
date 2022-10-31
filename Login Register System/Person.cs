using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register_System
{
    internal class Person
    {
        private string _fullname;
        private int _age;
        private string _newusername;
        private string _newpassword;
        private string _confpassword;
        private string _username;
        private string _password;
        public string FullName
        {
            get { return _fullname; }
            set { _fullname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string NewUsername
        {
            get { return _newusername; }
            set { _newusername = value; }
        }
        public string NewPassword
        {
            get { return _newpassword; }
            set { _newpassword = value; }
        }
        public string ConfPassword
        {
            get { return _confpassword; }
            set { _confpassword = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public Boolean Login(string username, string password)
        {
            if (username == "novaldy" & password == "12345")
            {
                return true;
            }
            else if (username == "yazid" & password == "02468")
            {
                return true;
            }
            else if (username == "christina" & password == "13579")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
