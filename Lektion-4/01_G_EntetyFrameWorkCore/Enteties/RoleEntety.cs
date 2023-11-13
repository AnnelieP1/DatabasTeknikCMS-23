using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_G_EntetyFrameWorkCore.Enteties;

internal class RoleEntety
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string RoleName { get; set; } = null!;
}

