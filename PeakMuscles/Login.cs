using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakMuscles
{
    class Login
    {
        private string username;
        private string password;
        
        public string Username { get => username; }
        public string Password { get => password; }

        public Login()
        {

        }

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}