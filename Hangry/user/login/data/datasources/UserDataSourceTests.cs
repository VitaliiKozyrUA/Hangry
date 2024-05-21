using Hangry.user.login.data.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.login.data.datasources
{
    [TestClass]
    public class UserDataSourceTests
    {
        private UserLocalDataSource _dataSource;

        [TestInitialize]
        public void Setup()
        {
            _dataSource = new UserLocalDataSource();
        }

        [TestMethod]
        public void Get_ValidCredentials_ReturnsUser()
        {
            var user = new User(1, "testuser", "testaddress", "password123");
            _dataSource.Add(user);
            var credentials = new Credentials("testuser", "password123");

            var result = _dataSource.Get(credentials);

            Assert.IsNotNull(result);
            Assert.AreEqual(user, result);
        }

        [TestMethod]
        public void Get_InvalidCredentials_ReturnsNull()
        {
            var user = new User(1, "testuser", "testaddress", "password123");
            _dataSource.Add(user);
            var credentials = new Credentials("invaliduser", "wrongpassword");

            var result = _dataSource.Get(credentials);

            Assert.IsNull(result);
        }
    }
}
