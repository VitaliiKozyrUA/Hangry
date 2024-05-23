using Hangry.common.data.models;
using Hangry.user.login.data.datasources;
using Hangry.user.login.data.models;
using Hangry.user.main;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.models
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void User_Constructor_ValidParameters_Success()
        {
            int id = 1;
            string name = "John";
            string address = "123 Main St";
            string password = "password";

            var user = new User(id, name, address, password);

            Assert.AreEqual(id, user.Id);
            Assert.AreEqual(name, user.Name);
            Assert.AreEqual(address, user.Address);
            Assert.AreEqual(password, user.Password);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void User_Constructor_InvalidId_ExceptionThrown()
        {
            int id = -1;
            string name = "John";
            string address = "123 Main St";
            string password = "password";

            new User(id, name, address, password);
        }

        [TestMethod()]
        public void User_LogIn_ValidCredentials_Success()
        {
            var credentials = new Credentials("username", "password");

            new User(0, credentials.Username, "Address", credentials.Password).Register();
            var user = User.LogIn(credentials);

            Assert.IsNotNull(user);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void User_LogIn_EmptyUsername_ExceptionThrown()
        {
            var credentials = new Credentials("", "password");

            User.LogIn(credentials);
        }

        [TestMethod()]
        public void User_Register_ValidCredentials_Success()
        {
            var credentials = new Credentials("username", "password");

            new User(0, credentials.Username, "Address", credentials.Password).Register();
        }

        [TestMethod()]
        public void User_SaveOrders_ValidOrders_Success()
        {
            var user = new User(1, "John", "123 Main St", "password");
            var product = new Product(1, "Name", "Description", 0.0, "//");
            var orders = new List<Order> { new Order(1, product, 10, 1, "2024-05-23") };

            OrderLocalDataSource.Clear();
            user.SaveOrders(orders);

            CollectionAssert.AreEqual(orders, user.GetOrders());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SaveOrders_InvalidQuantity_ExceptionThrown()
        {
            var user = new User(1, "John", "123 Main St", "password");
            var product = new Product(1, "Name", "Description", 0.0, "//");
            var orders = new List<Order> { new Order(1, product, 10, 0, "2024-05-23") };

            user.SaveOrders(orders);
        }

        [TestMethod()]
        public void User_GetOrders_ReturnsOrders_Success()
        {
            var user = new User(1, "John", "123 Main St", "password");
            var product = new Product(1, "Name", "Description", 0.0, "//");
            var orders = new List<Order> { new Order(1, product, 10, user.Id, "2024-05-23") };

            OrderLocalDataSource.Clear();
            user.SaveOrders(orders);
            var userOrders = user.GetOrders();

            CollectionAssert.AreEqual(orders, userOrders);
        }
    }
}
