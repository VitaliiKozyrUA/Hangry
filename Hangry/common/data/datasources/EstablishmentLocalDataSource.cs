using Hangry.common.data.models;
using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.common.data.datasources
{
    internal class EstablishmentLocalDataSource
    {
        private static DataStore store = new DataStore("data\\establishments.json");
        public delegate void EstablishmentEventHandler();
        public static event EstablishmentEventHandler? OnChanged;

        public static void Add(Establishment establishment)
        {
            var collection = store.GetCollection<Establishment>();
            collection.InsertOne(establishment);
            OnChanged?.Invoke();
        }

        public static void DeleteWhereId(int id)
        {
            var collection = store.GetCollection<Establishment>();
            collection.DeleteOne(id);
            OnChanged?.Invoke();
        }

        public static List<Establishment> GetAll()
        {
            var collection = store.GetCollection<Establishment>();
            return collection.AsQueryable().ToList();
        }

        public static void AddProduct(int establishmentId, Product product)
        {
            var collection = store.GetCollection<Establishment>();
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).First();
            if (establishment == null) return;
            var updatedEstablishment = establishment with { Products = establishment.Products.Add(product) };
            collection.DeleteOne(establishmentId);
            collection.InsertOne(updatedEstablishment);
            OnChanged?.Invoke();
        }

        public static void DeleteProductWhereId(int establishmentId, int id)
        {
            var collection = store.GetCollection<Establishment>();
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).First();
            if (establishment == null) return;
            var filtered = establishment.Products.Where(product => product.Id != id);
            var updatedEstablishment = establishment with { Products = filtered.ToImmutableList() };
            collection.DeleteOne(establishmentId);
            collection.InsertOne(updatedEstablishment);
            OnChanged?.Invoke();
        }

        public static List<Product> GetAllProducts(int establishmentId)
        {
            var collection = store.GetCollection<Establishment>();
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).FirstOrDefault();
            if (establishment == null) return new List<Product>();
            return establishment.Products.ToList();
        }
    }
}
