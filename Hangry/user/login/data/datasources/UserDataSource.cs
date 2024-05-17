using Hangry.administrator.login.data.models;
using Hangry.user.login.data.models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.login.data.datasources
{
    internal abstract class UserDataSource
    {
        public User? Get(models.Credentials credentials)
        {
            return GetUsers().Where(u => u.Name == credentials.Username && u.Password == credentials.Password).FirstOrDefault();
        }

        public void Add(User user)
        {
            var users = GetUsers().Add(user);
            SaveUsers(users.ToList());
        }

        protected abstract void SaveUsers(List<User> users);

        protected abstract ImmutableList<User> GetUsers();
    }
}