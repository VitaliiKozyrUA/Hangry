using Hangry.common.data.models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.main
{
    public record Order
    {
        public int Id { get; init; }
        public Product Product { get; init; }
        public int Quantity { get; init; }
        public int UserId { get; init; }
        public string Date { get; init; }

        public Order(
            int id,
            Product product,
            int quantity,
            int userId,
            string date)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            UserId = userId;
            Date = date;
        }
    }
}
