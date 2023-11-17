using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;

internal class InvoiceEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public DateTime OrderDate { get; set; } = DateTime.Now;
    
    [Required]
    public DateTime DueDate { get; set; } = DateTime.Now.AddDays(30);
    
    [Required]
    public string CustomerNumber { get; set; } = null!;
    
    [Required]
    public string CustomerName { get; set; } = null!;
    
    public string? AddressLine_1 { get; set; } 
    
    public string? AddressLine_2 { get; set; }
    
    public string? PostalCode { get; set; } 
   
    public string? City { get; set; } 
    
    [Required]
    public string CustomerEmail { get; set; } = null!;
    
    [Required]
    public string CustomerPhone { get; set; } = null!;

    [Required]
    [Column(TypeName = "money")]
    public decimal TotalAmount { get; set; }
    
    [Required]
    [Column(TypeName = "money")]
    public decimal Vat {  get; set; }

    public int OrderId { get; set; }

}
