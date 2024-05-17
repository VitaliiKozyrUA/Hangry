using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.login.data.models
{
    internal record User(
        int Id,
        string Name,
        string Address,
        string Password
    );
}
