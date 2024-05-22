using Hangry.common.data.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.main.data.datasources
{
    [TestClass]
    public class OrderLocalDataSourceTests
    {
        [TestMethod]
        public void AddAll_Should_InsertOrders()
        {
            var productA = new Product(1, "ProductA", "Description A", 10.0, "path/to/imageA");
            var productB = new Product(2, "ProductB", "Description B", 15.0, "path/to/imageB");

            var order1 = new Order(1, productA, 2, 1, DateTime.Now.ToString());
            var order2 = new Order(2, productB, 1, 2, DateTime.Now.ToString());
            var orders = new List<Order> { order1, order2 };

            OrderLocalDataSource.Clear();
            OrderLocalDataSource.AddAll(orders);

            var ordersFromDataSource = OrderLocalDataSource.GetWhereUserId(1);
            Assert.AreEqual(1, ordersFromDataSource.Count);
            Assert.AreEqual(order1, ordersFromDataSource[0]);
        }

        [TestMethod]
        public void GetWhereUserId_Should_ReturnOrdersForUserId()
        {
            var productA = new Product(1, "ProductA", "Description A", 10.0, "path/to/imageA");
            var productB = new Product(2, "ProductB", "Description B", 15.0, "path/to/imageB");
            var productC = new Product(3, "ProductC", "Description C", 20.0, "path/to/imageC");

            var order1 = new Order(1, productA, 2, 1, DateTime.Now.ToString());
            var order2 = new Order(2, productB, 1, 2, DateTime.Now.ToString());
            var order3 = new Order(3, productC, 3, 1, DateTime.Now.ToString());

            var orders = new List<Order> { order1, order2, order3 };
            OrderLocalDataSource.Clear();
            OrderLocalDataSource.AddAll(orders);

            var ordersForUser1 = OrderLocalDataSource.GetWhereUserId(1);
            var ordersForUser2 = OrderLocalDataSource.GetWhereUserId(2);

            Assert.AreEqual(2, ordersForUser1.Count);
            Assert.AreEqual(1, ordersForUser2.Count);
        }

        [TestMethod]
        public void Clear_Should_RemoveAllOrders()
        {
            var productA = new Product(1, "ProductA", "Description A", 10.0, "path/to/imageA");
            var productB = new Product(2, "ProductB", "Description B", 15.0, "path/to/imageB");

            var order1 = new Order(1, productA, 2, 1, DateTime.Now.ToString());
            var order2 = new Order(2, productB, 1, 2, DateTime.Now.ToString());

            var orders = new List<Order> { order1, order2 };
            OrderLocalDataSource.Clear();
            OrderLocalDataSource.AddAll(orders);

            OrderLocalDataSource.Clear();

            var ordersFromDataSource = OrderLocalDataSource.GetWhereUserId(1);
            Assert.AreEqual(0, ordersFromDataSource.Count);
        }
    }
}
