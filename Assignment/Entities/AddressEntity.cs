using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities;

internal class AddressEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string StreetName { get; set; } = null!;

    [Required]
    public string StreetNumber { get; set; } = null!;
    
    public string PostalCode { get; set; } = null!;
    
    [Required]
    public string City { get; set; } = null!;

    public ICollection<CustomerEntity> Customers { get; set; } = new List<CustomerEntity>();

}
