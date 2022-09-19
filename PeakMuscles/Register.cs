using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakMuscles
{
    class Register
    {
        private string _fullName;
        private int _ageID;
        private string _username;
        private string _password;
        private string _confirmpassword;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public int AgeID
        {
            get { return _ageID; }
        }
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string ConfirmPassword
        {
            get { return _confirmpassword; }
            set { _confirmpassword = value; }
        }

        public Register(string UserName, string Password)
        {
            _username = UserName;
            _password = Password;
        }
    }
}