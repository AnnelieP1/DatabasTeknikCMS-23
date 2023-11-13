using Customer_Embroidery_DataBase.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;
[Index(nameof(Email), IsUnique = true)]
internal class CustomerEntity 
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string PhoneNumber { get; set; } = null!;

    [Required]
    public int AddressId { get; set; } 
    public AddressEntity Address { get; set; } = null!;
  

}
