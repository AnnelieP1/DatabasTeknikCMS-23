using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models;

internal class Order
{
    public int Id { get; set; }
    public string OrderNumber { get; set; } = null!;
    public string OrderName { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string? AddressLine_1 { get; set; } 
    public string? AddressLine_2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
