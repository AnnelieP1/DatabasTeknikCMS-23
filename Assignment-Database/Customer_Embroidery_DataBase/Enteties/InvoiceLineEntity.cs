using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customer_Embroidery_DataBase.Enteties;

public class InvoiceLineEntity
{
    [Key]
    public int InvoiceId { get; set; }
    public int ProductId { get; set; }
    public string? Description { get; set; }

    [Required]

    [Column(TypeName = "money")]
    public decimal Price { get; set; }
    [Required]
    public int Quantity { get; set; }

    [Required]
    public ICollection<InvoiceLineEntity> Invoices { get; set; } = new List<InvoiceLineEntity>();

    
}