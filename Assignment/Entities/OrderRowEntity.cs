using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;


internal class OrderRowEntity
{
    public string OrderId { get; set; } = null!;

    public int ProductId { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }
    public int Quantity { get; set; }
    public string QuantityUnitId { get; set; } = null!;
    public QuantityUnitEntity QuanittyUnit { get; set; } = null!;

}
