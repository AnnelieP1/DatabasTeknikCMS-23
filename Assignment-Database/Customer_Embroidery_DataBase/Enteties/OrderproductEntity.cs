using System.ComponentModel.DataAnnotations;

namespace Customer_Embroidery_DataBase.Enteties;

internal class OrderproductEntity
{
    [Key]
    
    public int Id { get; set; }
    [Required]
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; } = null!;
    [Required]
    public string ProductDescription { get; set; } = null!;
    [Required]
    public string ProductCategory { get; set; } = null!;
    public string Quantity { get; set; } = null!;


    [Required]
    public int OrderproductId { get; set; }
    public ICollection<OrderproductEntity> Products { get; set; } = new List<OrderproductEntity>();
}
