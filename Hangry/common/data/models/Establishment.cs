using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.common.data.models
{
    public class Establishment
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string ImagePath { get; init; }
        public string Address { get; init; }
        public ImmutableList<Product> Products { get; init; }

        public Establishment(
            int id,
            string name,
            string imagePath,
            string address,
            ImmutableList<Product> products)
        {
            if (id < 0) throw new ArgumentException();
            if (name.Length == 0) throw new ArgumentException();
            if (imagePath.Length == 0) throw new ArgumentException();
            if (address.Length == 0) throw new ArgumentException();

            Id = id;
            Name = name;
            ImagePath = imagePath;
            Address = address;
            Products = products;
        }
    }
}
