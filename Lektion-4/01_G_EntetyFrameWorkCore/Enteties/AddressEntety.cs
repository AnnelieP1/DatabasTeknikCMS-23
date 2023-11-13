using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_G_EntetyFrameWorkCore.Enteties;

internal class AddressEntety
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string StreetName { get; set; } = null!;
    [Required]
    public string PostalCode { get; set; } = null!;
    [Required]
    public string City { get; set; } = null!;

    
   
}
