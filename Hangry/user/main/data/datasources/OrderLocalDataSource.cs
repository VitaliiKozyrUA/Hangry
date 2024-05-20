using Hangry.common.data.models;
using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.main
{
    internal class OrderLocalDataSource : IDisposable
    {
        private static DataStore store = new DataStore("data\\orders.json");
        private static IDocumentCollection<Order> collection = store.GetCollection<Order>();
        public delegate void OrderEventHandler();
        public static event OrderEventHandler? OnChanged;

        public static void AddAll(List<Order> order)
        {
            collection.InsertMany(order);
            OnChanged?.Invoke();
        }

        public static List<Order> GetWhereUserId(int userId)
        {
            return (from e in collection.AsQueryable() where e.UserId == userId select e).ToList();
        }

        public void Dispose()
        {
            store.Dispose();
        }
    }
}
