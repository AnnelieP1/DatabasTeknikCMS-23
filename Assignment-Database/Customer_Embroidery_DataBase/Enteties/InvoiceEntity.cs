using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;

internal class InvoiceEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public DateTime OrderDate { get; set; } = DateTime.Now;
    [Required]
    public DateTime DueDate {  get; set; } = DateTime.Now;
    [Required]
    public string CustomerNumber { get; set; } = null!;
    [Required]
    public string CustomerName { get; set; } = null!;
    
    public string? AddressLine_1 { get; set; } 
    public string? AddressLine_2 { get; set; } 
    public string? PostalCode { get; set; } 
    public string? City { get; set; }

    [Required]

    [Column(TypeName = "money")]
    public decimal TotalAmoubt { get; set; }

    [Column(TypeName = "money")]
    public decimal Vat {  get; set; }
    [Required]
    public int InvocieLineId { get; set; }
    public InvoiceLineEntity InvoiceLine { get; set; } = null!;
}
