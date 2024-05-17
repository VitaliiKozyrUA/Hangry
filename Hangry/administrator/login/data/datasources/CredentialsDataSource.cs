using Hangry.administrator.login.data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.administrator.login.data.datasources
{
    internal interface ICredentialsDataSource
    {
        Credentials GetCredentials();
    }
}
