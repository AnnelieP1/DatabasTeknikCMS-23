using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

internal class Invoice
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public DateTime DueDate {  get; set; } = DateTime.Now.AddDays(30);
    public string CustomerNumber { get; set; } = null!;
    public string CustomerName { get; set; } = null!;
    public string AddressLine_1 { get; set; } = null!;
    public string AddressLine_2 { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string CustomerEmail { get; set; } = null!;
    public string CustomerPhone { get; set; } = null!;
}
