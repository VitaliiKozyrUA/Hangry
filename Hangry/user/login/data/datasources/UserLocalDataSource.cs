using Hangry.administrator.login.data.models;
using Hangry.user.login.data.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.login.data.datasources
{
    internal class UserLocalDataSource : UserDataSource
    {
        private string filePath = Application.StartupPath + "data\\users.json";

        protected override ImmutableList<User> GetUsers()
        {
            if (!File.Exists(filePath))
            {
                return ImmutableList<User>.Empty;
            }

            var json = File.ReadAllText(filePath);
            var users = JsonConvert.DeserializeObject<List<User>>(json);

            if(users == null) return ImmutableList<User>.Empty;
            return users.ToImmutableList();
        }

        protected override void SaveUsers(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users);
            File.WriteAllText(filePath, json);
        }
    }
}
