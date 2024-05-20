using Hangry.common.data.models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.user.main
{
    public record Order(
        int Id,
        Product Product,
        int Quantity,
        int UserId,
        string date
    );
}
