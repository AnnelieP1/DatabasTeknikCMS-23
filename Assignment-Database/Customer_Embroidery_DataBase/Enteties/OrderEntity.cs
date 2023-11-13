using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;

internal class OrderEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int OrderNumber { get; set; }
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public DateTime OrderDate { get; set; } = DateTime.Now;
    [Required]
    public DateTime DueDate { get; set; } = DateTime.Now.AddDays(30);
    [Required]
    public string CustomerName { get; set; } = null!;
    [Required]
    public string CustomerAddress { get; set; } = null!;
    [Required]
    public string CustomerEmail { get; set; } = null!;
    [Required]
    public string CustomerPhoneNumber { get; set; } = null!;
    [Required]
    public string CustomerSpecification { get; set; } = null!;
    [Required]
    [Column(TypeName = "money")]
    public decimal TotalAmount { get; set; }  
    [Required]
    public string PaymentMethod { get; set; } = null!;

    [Required]
    public int OrderProductId { get; set; } 
    public OrderproductEntity Orderproduct{ get; set; } = null!; 

}
