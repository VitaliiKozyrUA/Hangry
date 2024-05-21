using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using JsonFlatFileDataStore;
using System.Collections.Generic;
using System.Linq;
using Hangry.common.data.models;
using Hangry.common.data.datasources;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hangry.common.data.datasources
{
    [TestClass]
    public class EstablishmentLocalDataSourceTests
    {
        [TestMethod]
        public void Add_AddsEstablishment()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment = new Establishment(1, "Test Establishment", "image.jpg", "123 Main St", ImmutableList<Product>.Empty);

            EstablishmentLocalDataSource.Add(establishment);
            var establishments = EstablishmentLocalDataSource.GetAll();

            Assert.AreEqual(1, establishments.Count);
            Assert.AreEqual(1, establishments[0].Id);
            Assert.AreEqual("Test Establishment", establishments[0].Name);
        }

        [TestMethod]
        public void DeleteWhereId_DeletesEstablishment()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment = new Establishment(1, "Test Establishment", "image.jpg", "123 Main St", ImmutableList<Product>.Empty);
            EstablishmentLocalDataSource.Add(establishment);

            EstablishmentLocalDataSource.DeleteWhereId(1);
            var establishments = EstablishmentLocalDataSource.GetAll();

            Assert.AreEqual(0, establishments.Count);
        }

        [TestMethod]
        public void AddProduct_AddsProductToEstablishment()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment = new Establishment(1, "Test Establishment", "image.jpg", "123 Main St", ImmutableList<Product>.Empty);
            EstablishmentLocalDataSource.Add(establishment);
            Product product = new Product(1, "Test Product", "Description", 10.99, "product.jpg");

            EstablishmentLocalDataSource.AddProduct(1, product);
            var products = EstablishmentLocalDataSource.GetAllProducts(1);

            Assert.AreEqual(1, products.Count);
            Assert.AreEqual(1, products[0].Id);
            Assert.AreEqual("Test Product", products[0].Name);
        }

        [TestMethod]
        public void DeleteProductWhereId_DeletesProductFromEstablishment()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment = new Establishment(1, "Test Establishment", "image.jpg", "123 Main St", ImmutableList.Create(new Product(1, "Test Product", "Description", 10.99, "product.jpg")));
            EstablishmentLocalDataSource.Add(establishment);

            EstablishmentLocalDataSource.DeleteProductWhereId(1, 1);
            var products = EstablishmentLocalDataSource.GetAllProducts(1);

            Assert.AreEqual(0, products.Count);
        }

        [TestMethod]
        public void GetAll_ReturnsAllEstablishments()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment1 = new Establishment(1, "Test Establishment 1", "image1.jpg", "123 Main St", ImmutableList<Product>.Empty);
            Establishment establishment2 = new Establishment(2, "Test Establishment 2", "image2.jpg", "456 Elm St", ImmutableList<Product>.Empty);
            EstablishmentLocalDataSource.Add(establishment1);
            EstablishmentLocalDataSource.Add(establishment2);

            var establishments = EstablishmentLocalDataSource.GetAll();

            Assert.AreEqual(2, establishments.Count);
            Assert.IsTrue(establishments.Any(e => e.Id == 1 && e.Name == "Test Establishment 1"));
            Assert.IsTrue(establishments.Any(e => e.Id == 2 && e.Name == "Test Establishment 2"));
        }

        [TestMethod]
        public void GetAllProducts_ReturnsAllProductsForEstablishment()
        {
            EstablishmentLocalDataSource.Clear();
            Establishment establishment = new Establishment(1, "Test Establishment", "image.jpg", "123 Main St", ImmutableList.Create(new Product(1, "Test Product 1", "Description", 10.99, "product1.jpg"), new Product(2, "Test Product 2", "Description", 20.99, "product2.jpg")));
            EstablishmentLocalDataSource.Add(establishment);

            var products = EstablishmentLocalDataSource.GetAllProducts(1);

            Assert.AreEqual(2, products.Count);
            Assert.IsTrue(products.Any(p => p.Id == 1 && p.Name == "Test Product 1"));
            Assert.IsTrue(products.Any(p => p.Id == 2 && p.Name == "Test Product 2"));
        }
    }
}