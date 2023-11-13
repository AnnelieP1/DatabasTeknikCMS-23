using Customer_Embroidery_DataBase.Enteties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models;

internal class ProductTypes
{
    [Key]
    public int Id { get; set; }
    [Required]  
    public string TypeName { get; set; } = null!;

    [Required]
    public int ProductEntityId { get; set; }
    public ICollection<ProductEntity> ProductEntities { get; set; } = new List<ProductEntity>();
}
