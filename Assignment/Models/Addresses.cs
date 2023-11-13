using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models;

internal class Addresses
{
   
    public int AddressId { get; set; }
   
    public string StreetName { get; set; } = null!;
    
    public int? StreetNumber { get; set; }
    
    public string PostalCode { get; set; } = null!;
    
    public string City { get; set; } = null!;

    

}
