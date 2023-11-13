using System.ComponentModel.DataAnnotations;

namespace Customer_Embroidery_DataBase.Enteties;

internal class CategoryEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string CategoryName { get; set; } = null!;

    [Required]

    public int ProductId { get; set; }
    [Required]
    public int SubcategoryId { get; set; }
    public ICollection<ProductEntity> Product { get; set; } = null!;
    public ICollection<SubCategoryEntity> Subcategory { get; set; } = null!;


}
