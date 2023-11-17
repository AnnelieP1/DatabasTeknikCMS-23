using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal StockPrice { get; set; }
        public int QuantityUnitId { get; set; }
        public QuantityUnitEntity QuanittyUnit { get; set; } = null!;

    }
}
