using Customer_Embroidery_DataBase.Enteties;
using Customer_Embroidery_DataBase.Services.AdminService;
using Customer_Embroidery_DataBase.Services.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Embroidery_DataBase.Models;

internal class Users
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string UserName { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
    [Required]
    public string AdminId { get; set; } = null!;
    [Required]
    public ICollection<AdminEntity> Admins { get; set; } = new List<AdminEntity>();
    

    
}
