using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_EntetyFramework.Enteties;

internal class ProductEntety
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public string? Description { get; set; }
    public decimal Price { get; set; }
    public CategoryEntity Category { get; set; } = null!;
    public int CategoryId { get; set; }
}
