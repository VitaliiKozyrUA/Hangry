using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangry.common.data.models
{
    public record Product(
        int Id,
        string Name,
        string Description,
        double Price,
        string ImagePath
    );
}
