using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;

internal class AddressEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string StreetName { get; set; } = null!;
    [Required]
    public string StreetNumber { get; set; } = null!;
    [Required]
    public string PostalCode { get; set; } = null!;
    [Required]
    public string City { get; set; } = null!;

    public ICollection<UserEntity> Customers { get; set; } = null!;
}
