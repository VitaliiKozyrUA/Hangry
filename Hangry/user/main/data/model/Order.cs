using Hangry.common.data.models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.main
{
    public class Order
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Order otherOrder = (Order)obj;
            return Id == otherOrder.Id &&
                   Product == otherOrder.Product &&
                   Quantity == otherOrder.Quantity &&
                   UserId == otherOrder.UserId &&
                   Date == otherOrder.Date;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Product, Quantity, UserId, Date);
        }
    }
}
