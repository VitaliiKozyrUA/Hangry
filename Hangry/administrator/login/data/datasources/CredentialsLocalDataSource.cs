using Hangry.administrator.login.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.administrator.login.data.datasources
{
    internal class CredentialsLocalDataSource : ICredentialsDataSource
    {
        public Credentials GetCredentials()
        {
            var password = File.ReadAllText(Application.StartupPath + "data\\adminCredentials.txt");
            return new Credentials(password);
        }
    }
}
