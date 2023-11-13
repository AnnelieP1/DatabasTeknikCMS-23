using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Enteties;

internal class AdminEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string AdminUserName { get; set; } = null!;
    [Required]
    public string AdminUserRole { get; set; } = null!;

    [Required]
    public string AdminPassword { get; set; } = null!;
    [Required]
    public int CustomerEntityId { get; set; }
}
