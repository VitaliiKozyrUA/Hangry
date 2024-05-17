using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.common.data.models
{
    public record Establishment(
        int Id,
        string Name,
        string ImagePath,
        string Address,
        ImmutableList<Product> Products
    );
}
