using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.common.data.models
{
    public class Product
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public double Price { get; init; }
        public string ImagePath { get; init; }

        public Product(
            int id,
            string name,
            string description,
            double price,
            string imagePath)
        {
            if (id < 0) throw new ArgumentException();
            if (name.Length == 0) throw new ArgumentException();
            if (description.Length == 0) throw new ArgumentException();
            if (price < 0) throw new ArgumentException();
            if (imagePath.Length == 0) throw new ArgumentException();

            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
