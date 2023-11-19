using Assignment.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models;

internal class Address
{
   
    public int AddressId { get; set; }
   
    public int StreetName { get; set; } 
    
    public string StreetNumber { get; set; } = null!;
    
    public string PostalCode { get; set; } = null!;
    
    public string City { get; set; } = null!;

    internal static object ToListAsync()
    {
        throw new NotImplementedException();
    }
}
