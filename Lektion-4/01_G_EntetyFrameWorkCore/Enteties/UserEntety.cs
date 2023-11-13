using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_G_EntetyFrameWorkCore.Enteties;

internal class UserEntety
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int RoleId { get; set; }
    public RoleEntety Role { get; set; } = null!;

    [Required]
    public int AddressId { get; set; }
    public AddressEntety Address { get; set; } = null!;

    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;
    [Required]
    public string Email { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;

   

}
