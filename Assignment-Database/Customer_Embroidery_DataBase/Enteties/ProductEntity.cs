using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;

internal class ProductEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Description { get; set; } = null!;
    [Required]
    [Column(TypeName = "money")]
    public decimal StockPrice { get; set; }

    [Required]
    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
}
