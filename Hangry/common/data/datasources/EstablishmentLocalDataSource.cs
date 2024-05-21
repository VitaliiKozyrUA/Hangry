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
    internal class EstablishmentLocalDataSource : IDisposable
    {
        private static DataStore store = new DataStore("data\\establishments.json");
        private static IDocumentCollection<Establishment> collection = store.GetCollection<Establishment>();
        public delegate void EstablishmentEventHandler();
        public static event EstablishmentEventHandler? OnChanged;

        public static void Add(Establishment establishment)
        {
            collection.InsertOne(establishment);
            OnChanged?.Invoke();
        }

        public static void DeleteWhereId(int id)
        {
            collection.DeleteOne(id);
            OnChanged?.Invoke();
        }

        public static List<Establishment> GetAll()
        {
            return collection.AsQueryable().ToList();
        }

        public static void AddProduct(int establishmentId, Product product)
        {
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).FirstOrDefault();
            if (establishment == null) return;
            var updated = establishment with { Products = establishment.Products.Add(product) };
            collection.ReplaceOne(establishmentId, updated);
            OnChanged?.Invoke();
        }

        public static void DeleteProductWhereId(int establishmentId, int id)
        {
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).FirstOrDefault();
            if (establishment == null) return;
            var filtered = establishment.Products.Where(product => product.Id != id);
            var updated = establishment with { Products = filtered.ToImmutableList() };
            collection.ReplaceOne(establishmentId, updated);
            OnChanged?.Invoke();
        }

        public static List<Product> GetAllProducts(int establishmentId)
        {
            var establishment = (from e in GetAll() where e.Id == establishmentId select e).FirstOrDefault();
            if (establishment == null) return new List<Product>();
            return establishment.Products.ToList();
        }

        public static void Clear()
        {
            collection.DeleteMany(e => true);
        }

        public void Dispose()
        {
            store.Dispose();
        }
    }
}
