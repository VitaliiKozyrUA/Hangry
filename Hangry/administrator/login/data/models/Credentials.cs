﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.administrator.login.data.models
{
    internal class Credentials
    {
        public string Password { get; set; }

        public Credentials(string password) {
        Password = password;
        }
    }
}
