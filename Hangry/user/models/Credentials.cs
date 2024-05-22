using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.login.data.models
{
    internal class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Credentials(string username, string password) { 
            Username = username;
            Password = password;
        }
    }
}
